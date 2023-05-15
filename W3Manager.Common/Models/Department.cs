using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Common.Models
{
    /// <summary>
    /// Represents an abstract Employee object
    /// </summary>
    /// <seealso cref="EmployeeType"/>
    /// <seealso cref="Models.Person"/>
    /// <seealso cref="EmployeeBenefits"/>    
    public  class Department
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class with default values
        /// </summary>
        public Department()
        {
            Id = -1;
            Name = string.Empty;
            Positions = new List<Position>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class with parameter values
        /// </summary>
        /// <param name="person">Person object</param>
        /// <param name="type">EType employee status</param>
        /// <param name="id">Employee ID</param>
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
            Positions = new List<Position>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class with parameter values
        /// </summary>
        /// <param name="person">Person object</param>
        /// <param name="type">EType employee status</param>
        /// <param name="id">Employee ID</param>
        public Department(int id, string name, List<Position> positions)
        {
            Id = id;
            Name = name;
            Positions = positions;
        }
        public Department(string number, string name)
        {
            Name = name;

            Positions = new List<Position>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Position> Positions;
        public decimal MonthlySalary { get; set; }
        public decimal AnnualSalary { get; set; }
    }

    public class Position
    {
        private int _id;
        private string _name;
        private int _idDepartment;

        public Position(int id, string name, int idDepartment)
        {
            Id = id;
            Name = name;
            IdDepartment = idDepartment;
        }
        public Position(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Position()
        {
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int IdDepartment
        {
            get => _idDepartment;
            set => _idDepartment = value;
        }
    }
}
