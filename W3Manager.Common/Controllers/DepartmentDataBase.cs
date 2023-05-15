using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Common.Models;

namespace EmployeeManagementSystem.Common.Controllers
{
    public class DepartmentDataBase
    {

        private Department department;
        public DepartmentDataBase()
        {
        }
        public DepartmentDataBase(Department department)
        {
            this.department = department;
        }
        public void AddDepartment()
        {
            DataBase dataBase = new DataBase();
            dataBase.UpdateDepartment(department);
        }
        public SortedDictionary<int, Department> GetDepartments()
        {
            DataBase dataBase = new DataBase();
            var  departments =  dataBase.GetDepartments();
            foreach (var department in departments)
            {
                department.Value.Positions = dataBase.GetPositions(department.Key);
            }
            return departments;
        }
        public bool RemoveDepartment(uint id)
        {
            DataBase dataBase = new DataBase();
            dataBase.DeleteDepartment((int)id);

            return true;
        }
    }
}
