using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using EmployeeManagementSystem.Common.Models;

namespace EmployeeManagementSystem.Common.Controllers
{

    public class DataBase
    {

        public SqlConnection conn;
        public string ConnectString;
        public string ErrStr = "";
    

        private int _tryConnectTimeOut;
        private int commandTimeout = 3000;
        public string GetConnectString()
        {
            if (string.IsNullOrEmpty(ConnectString))
                try
                {
                    DataBaseSettings ds = new SettingsSerializer().Deserialize();
                    ConnectString +=
                        @"User Id="+ds.User+";Password="+ds.Password+"; " +
                        "MultipleActiveResultSets="+ds.MultipleActiveResultSets+";" +
                        "Server="+ds.Server+";" +
                        "Database="+ds.Database+"; ";
                }
                catch (Exception ex)
                {
                    ErrStr = $"ERROR GetConnectString DB: {ex.Message}";
                }

            return ConnectString;
        }


        protected bool Reconnect()
        {
            try
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
            catch (Exception ex)
            {
                ErrStr = $"ERROR Reconnect DB: {ex.Message}";
                return false;
            }

            return Connect();
        }

        public bool Connect()
        {
            ErrStr = "";

            if (conn == null) conn = new SqlConnection();
            if (conn.State == ConnectionState.Open) return true;
            if (conn.State == ConnectionState.Executing || conn.State == ConnectionState.Fetching)
            {
                // чекаємо 10 сек. закінчення поточного запиту
                var secondCounter = 0;
                while (conn.State != ConnectionState.Open)
                {
                    Thread.Sleep(500);
                    if (secondCounter++ > 20) ErrStr = "Connect() wait end Executing/Fetching too long (10 sec)";
                    return false;
                }
            }

            if (string.IsNullOrEmpty(conn.ConnectionString)) conn.ConnectionString = GetConnectString();
            else if (conn.ConnectionString != ConnectString) return Reconnect();

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                ErrStr = $"ERROR connect DB: {ex.Message}";
                return false;
            }

            if (conn.State != ConnectionState.Open) return false;
            return true;
        }

        public  List <Course> GetCourse(int personId)
        {
            List<Course> dic = new List<Course>();

            if (!Connect())
            {
                return dic;
            }

            using (var cmd = new SqlCommand("GetProductLst", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT [CourseId]
                                      ,[CourseName]
                                      ,[Description]
                                      ,[Credits]
                                      ,[Approved]
                                      ,[ApprovedDate]
                                      ,[PersonId]
                                      ,[ID]
                                  FROM [EmployeeManagement].[dbo].[Course] where PersonId = PersonId";
                    cmd.Parameters.Add("@PersonId", SqlDbType.Int).Value = personId;

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Course course = new Course();       
                        course.CourseId = reader["ID"] as string;
                        course.CourseName = reader["CourseName"] as string;
                        course.Description = reader["Description"] as string;
                        course.Credits = (int)reader["Credits"];
                        course.Approved = (bool) reader["Approved"];
                        course.ApprovedDate = (DateTime)reader["ApprovedDate"];
                        course.PersonId = personId;
                        dic.Add(course);                 
                        
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    ErrStr = $"ERROR GetCourse DB: {ex.Message}";
                }
            }


            return dic;
        }

        public bool AddCourse(Course course)
        {
            var isOk = true;
            if (!Connect())
            {

                return false;
            }

            string sql = @"INSERT INTO Course
       ([CourseName]
       ,[Description]
       ,[Credits]
       ,[Approved]
       ,[ApprovedDate]
       ,[PersonId]
, ID)
 VALUES
       (@CourseName
       ,@Description
       ,@Credits
       ,@Approved
       ,@ApprovedDate
       ,@PersonId
,@ID)";
            using (var cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = course.CourseId;
                    cmd.Parameters.Add("@PersonId", SqlDbType.Int).Value = course.PersonId;
                    cmd.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = course.CourseName;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = course.Description;
                    cmd.Parameters.Add("@Credits", SqlDbType.Int).Value = course.Credits;
                    cmd.Parameters.Add("@Approved", SqlDbType.Bit).Value = course.Approved?1:0;
                    cmd.Parameters.Add("@ApprovedDate", SqlDbType.Date).Value = course.ApprovedDate;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    isOk = false;
                    ErrStr = $"ERROR AddCourse DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return isOk;
        }

        public bool UpdateCourse(Course course)
        {
            var isOk = true;
            if (!Connect())
            {
                return false;
            }

            string sql = @"UPDATE [Course]
   SET [Description] = @Description
      ,[Credits] = @Credits
      ,[Approved] =@Approved
      ,[ApprovedDate] =@ApprovedDate
      ,[PersonId] = @PersonId
      ,CourseName  = @CourseName
     WHERE ID  = @ID";
            using (var cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = course.CourseId;
                    cmd.Parameters.Add("@PersonId", SqlDbType.Int).Value = course.PersonId;
                    cmd.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = course.CourseName;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = course.Description;
                    cmd.Parameters.Add("@Credits", SqlDbType.Int).Value = course.Credits;
                    cmd.Parameters.Add("@Approved", SqlDbType.Bit).Value = course.Approved ? 1 : 0;
                    cmd.Parameters.Add("@ApprovedDate", SqlDbType.Date).Value = course.ApprovedDate;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    isOk = false;
                    ErrStr = $"ERROR UpdateCourse DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return isOk;
        }
        
        public bool UpdateHourly(Hourly employee) //!
        {
            var isOk = true;
            if (!Connect())
            {

                return false;
            }

            string sql =
                @"if exists (SELECT 1 Id FROM Person where  Id = @Id)
	        UPDATE  Person   SET 			
			[FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Street] = @Street
      ,[City] = @City
     
      ,[Phone] = @Phone     
      ,[Wage] = @Wage                     
       ,[Hours] = @Hours    
      ,[IdType] = @IdType 
, IdPosition = (SELECT  Id    FROM PositionDepartment where PositionId = @IdPosition) 
WHERE Id = @Id
else
	        insert Person 
			 ([FirstName],[LastName] ,[Street],[City],[Phone], [Wage], [Hours]   ,[IdType], IdPosition)
     VALUES
          (@FirstName,@LastName,@Street,@City, @Phone ,@Wage, @Hours ,@IdType,
(SELECT  Id    FROM PositionDepartment where PositionId = @IdPosition) );";
    
            using (var cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = employee.Id;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employee.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName;
                    cmd.Parameters.Add("@Street", SqlDbType.NVarChar).Value = employee.Street;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = employee.City;
                    
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = employee.Phone;
                    cmd.Parameters.Add("@IdType", SqlDbType.Int).Value = (int)employee.Type;

                    cmd.Parameters.Add("@Wage", SqlDbType.Decimal).Value = employee.HourlyRate; // wage
                    cmd.Parameters.Add("@Hours", SqlDbType.Decimal).Value = employee.Hours;

                    cmd.Parameters.Add("@IdPosition", SqlDbType.Int).Value = employee.position.Id;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    isOk = false;
                    ErrStr = $"ERROR UpdateHourly DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return isOk;
        }

        public bool UpdateSalary(Salary employee) 
        {
            var isOk = true;
            if (!Connect())
            {

                return false;
            }

            string sql = @"if exists (SELECT 1 Id FROM Person where  Id = @Id)
	        UPDATE  Person   SET 			
			[FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Street] = @Street
      ,[City] = @City        
      ,[Phone] = @Phone     
      ,[Salary] = @Salary       
      ,[IdType] = @IdType 
      ,  IdPosition = (SELECT  Id    FROM PositionDepartment where PositionId = @IdPosition) 

WHERE Id = @Id
else
	        insert Person 
			 ([FirstName],[LastName] ,[Street],[City] ,[Phone]  ,[Salary]  ,[IdType], IdPosition)
     VALUES
          (@FirstName,@LastName,@Street,@City,@Phone ,@Salary ,@IdType, (SELECT  Id    FROM PositionDepartment where PositionId = @IdPosition) );";
            using (var cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = employee.Id;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employee.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName;
                    cmd.Parameters.Add("@Street", SqlDbType.NVarChar).Value = employee.Street;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = employee.City;
                   
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = employee.Phone;
                    cmd.Parameters.Add("@IdType", SqlDbType.Int).Value = (int)employee.Type;

                    cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = employee.MonthlySalary;

                    cmd.Parameters.Add("@IdPosition", SqlDbType.Int).Value = employee.position.Id;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    isOk = false;
                    ErrStr = $"ERROR UpdateSalary DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return isOk;
        }

        public bool UpdateSales(Sales employee)//!
        {
            var isOk = true;
            if (!Connect())
            {

                return false;
            }

            string sql = @"if exists (SELECT 1 Id FROM Person where  Id = @Id)
	        UPDATE  Person   SET 			
			[FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Street] = @Street
      ,[City] = @City
     
      ,[Phone] = @Phone     
      ,[ComissionRate] = @ComissionRate                     
       ,[GrossSales] = @GrossSales    
      ,[IdType] = @IdType 
 ,IdPosition   = (SELECT  Id    FROM PositionDepartment where PositionId = @IdPosition) 
WHERE Id = @Id
else
	        insert Person 
			 ([FirstName],[LastName] ,[Street],[City] ,[Phone],[ComissionRate] ,[GrossSales]   ,[IdType], IdPosition)
     VALUES
          (@FirstName,@LastName,@Street,@City,@Phone ,@ComissionRate  ,@GrossSales ,@IdType , (SELECT  Id    FROM PositionDepartment where PositionId = @IdPosition) );";
            using (var cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = employee.Id;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employee.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName;
                    cmd.Parameters.Add("@Street", SqlDbType.NVarChar).Value = employee.Street;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = employee.City;
                   
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = employee.Phone;
                    cmd.Parameters.Add("@IdType", SqlDbType.Int).Value = (int)employee.Type;

                    cmd.Parameters.Add("@ComissionRate", SqlDbType.Decimal).Value = employee.SalesCommission;
                    cmd.Parameters.Add("@GrossSales", SqlDbType.Decimal).Value = employee.GrossSales;
                    cmd.Parameters.Add("@IdPosition", SqlDbType.Int).Value = employee.position.Id;

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    isOk = false;
                    ErrStr = $"ERROR UpdateSales DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return isOk;
        }

        public bool UpdateContract(Contract employee)
        {
            var isOk = true;
            if (!Connect())
            {

                return false;
            }

            string sql = @"if exists (SELECT 1 Id FROM Person where  Id = @Id)
	        UPDATE  Person   SET 			
			[FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Street] = @Street
      ,[City] = @City
    
      ,[Phone] = @Phone     
      ,Wage =@Wage,[IdType] = @IdType 
,IdPosition = (SELECT  Id    FROM PositionDepartment where PositionId = @IdPosition) 
WHERE Id = @Id
else
	        insert Person 
			 ([FirstName],[LastName] ,[Street],[City] ,[Phone],Wage    ,[IdType],  IdPosition)
     VALUES
          (@FirstName,@LastName,@Street,@City,@Phone ,@Wage  ,@IdType,  (SELECT  Id    FROM PositionDepartment where PositionId = @IdPosition));";
            using (var cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = employee.Id;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employee.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName;
                    cmd.Parameters.Add("@Street", SqlDbType.NVarChar).Value = employee.Street;
                    cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = employee.City;
                 
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = employee.Phone;
                    cmd.Parameters.Add("@IdType", SqlDbType.Int).Value = (int)employee.Type;

                    cmd.Parameters.Add("@Wage", SqlDbType.Decimal).Value = employee.ContractWage;
                    cmd.Parameters.Add("@IdPosition", SqlDbType.Int).Value = employee.position.Id;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    isOk = false;
                    ErrStr = $"ERROR UpdateContract DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return isOk;
        }
        public bool DeleteEmployee(int idEmployee)
        {
            var ok = true;
            if (!Connect())
            {
                return false;
            }

            using (var cmd = new SqlCommand("SetOrderProduct", conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE FROM Person  WHERE Id = @idEmployee";
                    cmd.Parameters.Add("@idEmployee", SqlDbType.Int).Value = idEmployee;

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ok = false;
                    ErrStr = $"ERROR DeleteEmployee DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return ok;
        }

        public SortedDictionary<int, Employee> GetEmployees()
        {
            var dic = new SortedDictionary<int, Employee>();
           
            if (!Connect())
            {
                return dic;
            }

            using (var cmd = new SqlCommand("GetProductLst", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        @"SELECT Person.Id
                        ,[FirstName]
                        ,[LastName]
                        ,[Street]
                        ,[City]  
                        ,[Phone]
                        ,[Wage]
                        ,[Salary]
                        ,[Hours]
                        ,[ComissionRate]
                        ,[GrossSales]
                        ,[IdType]					 
						,Positions.Id as IdPosition
						,Positions.Name
                    FROM [Person] 
					inner join PositionDepartment on PositionDepartment.Id = Person.IdPosition
					inner join Positions on  PositionDepartment.PositionId  = Positions.Id
					
					order by Person.Id desc";

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                    
                        Person person = new Person();
                        person.FirstName = reader["FirstName"] as string;
                        person.LastName = reader["LastName"] as string;
                        person.Street = reader["Street"] as string;
                        person.City = reader["City"] as string;
                        person.Phone = reader["Phone"] as string;
                        var id = (int) reader["Id"];
                        EmployeeType type =  (EmployeeType)(int)reader["IdType"];
                        Employee employee;
                        switch (type)
                        {
                            case EmployeeType.Contract:
                                employee = new Contract(person, 
                                    (decimal)reader["Wage"],
                                    id);
                                employee.position.Name = reader["Name"] as string;
                                employee.position.Id = (int)reader["IdPosition"];
                                employee.Type = type;
                               // GetPerson(reader, ref employee);
                                dic.Add(id, employee);
                                //employee.Benefits = new EmployeeBenefits();
                                break;
                            case EmployeeType.Hourly:
                                employee = new Hourly(person,
                                    (decimal)reader["Wage"],
                                    (decimal)reader["Hours"],
                                    id);
                                employee.position.Name = reader["Name"] as string;
                                employee.position.Id = (int)reader["IdPosition"];
                                employee.Type = type;
                               // GetPerson(reader, ref employee);
                                dic.Add(id, employee);
                                break;
                            case EmployeeType.Salary:
                                employee = new Salary(person,
                                    (decimal)reader["Salary"],
                                    id);
                                employee.position.Name = reader["Name"] as string;
                                employee.position.Id = (int)reader["IdPosition"];
                                employee.Type = type;
                                dic.Add(id, employee);
                                break;
                            case EmployeeType.Sales:
                                employee = new Sales(person,
                                    (decimal)reader["Salary"],
                                    (decimal)reader["ComissionRate"],
                                    (decimal)reader["GrossSales"],
                                    id);
                                employee.position.Name = reader["Name"] as string;
                                employee.position.Id = (int)reader["IdPosition"];
                                employee.Type = type;
                                dic.Add(id, employee);
                                break;
                        }

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    ErrStr = $"ERROR SortedDictionary DB: {ex.Message}";
                }
            }


            return dic;
        }
        
        public List<Position>  GetPositions(int idDepartment)
        {
            var dic = new List<Position>();

            if (!Connect())
            {
                return dic;
            }

            using (var cmd = new SqlCommand("GetProductLst", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT Positions.Id  , Positions.[Name] FROM [PositionDepartment]
                    inner join Positions on PositionDepartment.PositionId  =  Positions.Id 
                    Where DepartmentId = @DepartmentId";
                    cmd.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = idDepartment;
                    var reader = cmd.ExecuteReader();

                    Position position;
                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        position = new Position(
                            id, reader["Name"] as string, idDepartment);

                        dic.Add( position);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    ErrStr = $"ERROR GetPositions DB: {ex.Message}";
                }
            }

            return dic;
        }

        #region Department
        public SortedDictionary<int, Department> GetDepartments()
        {
            var dic = new SortedDictionary<int, Department>();

            if (!Connect())
            {
                return dic;
            }

            using (var cmd = new SqlCommand("GetProductLst", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT[Id], [Number], [Name], ISNULL(AnnualSalary, 0 ) as AnnualSalary, ISNULL(MonthlySalary, 0 ) as MonthlySalary
                    FROM[Departments] order by id desc";

                    var reader = cmd.ExecuteReader();

                    Department department;
                    while (reader.Read())
                    {
                        department = new Department();
                        int id = (int)reader["Id"];
                        department.Id = id;
                        department.Name = reader["Name"] as string;
                        department.AnnualSalary = (decimal)reader["AnnualSalary"];
                        department.MonthlySalary = (decimal)reader["MonthlySalary"];

                        dic.Add(id, department);

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    ErrStr = $"ERROR SortedDictionary DB: {ex.Message}";
                }
            }

            return dic;
        }
        public bool UpdateDepartment(Department department)
        {
            var isOk = true;
            if (!Connect())
            {

                return false;
            }

            string sql = @"if exists (SELECT 1 Id FROM Departments  where  Id = @Id)
UPDATE [dbo].[Departments]
   SET [Number] = ''
      ,[Name] = @Name
 WHERE Id = @Id

else
INSERT INTO [dbo].[Departments]
           ([Number]
           ,[Name])
     VALUES
           (''
           ,@Name);";
            using (var cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = department.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = department.Name;
                    
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    isOk = false;
                    ErrStr = $"ERROR UpdateDepartment DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return isOk;
        }

        public bool DeleteDepartment(int idDepartment)
        {
            var ok = true;
            if (!Connect())
            {
                return false;
            }

            using (var cmd = new SqlCommand("SetOrderProduct", conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE FROM Departments  WHERE Id = @idDepartment";
                    cmd.Parameters.Add("@idDepartment", SqlDbType.Int).Value = idDepartment;

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ok = false;
                    ErrStr = $"ERROR DeleteDepartment DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return ok;
        }
        #endregion Department

        public List<Position> GetPositions( )
        {
            var dic = new List<Position>();

            if (!Connect())
            {
                return dic;
            }

            using (var cmd = new SqlCommand("GetProductLst", conn))
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT  [Id]      ,[Name]  FROM [Positions]";

                    var reader = cmd.ExecuteReader();

                    Position position;
                    while (reader.Read())
                    {
                        position = new Position((int)reader["Id"], reader["Name"] as string);

                        dic.Add(position);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    ErrStr = $"ERROR GetPositions DB: {ex.Message}";
                }
            }

            return dic;
        }

        public bool UpdateDepartmentPosition(Position employee)
        {
            var isOk = true;
            if (!Connect())
            {

                return false;
            }

            string sql = @"INSERT INTO [PositionDepartment]
([DepartmentId]           ,[Name]           ,[PositionId])
VALUES(@DepartmentId ,'' , @PositionId)";

          
            using (var cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@PositionId", SqlDbType.Int).Value = employee.Id;
                    cmd.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = employee.IdDepartment;

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    isOk = false;
                    ErrStr = $"ERROR UpdateDepartmentPosition DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return isOk;
        }

        public bool RemoveDepartmentPosition(int positionId, int departmentId)
        {
            var isOk = true;
            if (!Connect())
            {

                return false;
            }

            string sql = @"DELETE FROM [PositionDepartment] WHERE DepartmentId = @DepartmentId AND PositionId = @PositionId";


            using (var cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@PositionId", SqlDbType.Int).Value = positionId;
                    cmd.Parameters.Add("@DepartmentId", SqlDbType.Int).Value = departmentId;

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    isOk = false;
                    ErrStr = $"ERROR RemoveDepartmentPosition DB: {ex.Message}";
                }
                finally
                {
                    conn.Close();
                }
            }

            return isOk;
        }
    }
}
