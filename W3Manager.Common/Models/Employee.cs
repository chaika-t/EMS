namespace EmployeeManagementSystem.Common.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents an abstract Employee object
    /// </summary>
    /// <seealso cref="EmployeeType"/>
    /// <seealso cref="Models.Person"/>
    /// <seealso cref="EmployeeBenefits"/>    
    public abstract class Employee:Person
    {
        /// <summary>
        /// Gets or sets the <see cref="EmployeeBenefits"/>
        /// </summary>
        /// <remark>
        /// This is a public field so we can access and manipulate the underlying fields on the struct
        /// </remark>       
        public EmployeeBenefits Benefits;

      

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class with default values
        /// </summary>
        protected Employee()
        {
            // this.Person = new Person();
            this.Type = EmployeeType.Salary;
            this.Id = -1;
            this.Benefits = new EmployeeBenefits
            {
                Benefits = false,
                Compensation = string.Empty,
                Commission = false,
                Overtime = false,
                Education = false,
                Courses = new SortedDictionary<string, Course>()
            };      
            position = new Position();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class with parameter values
        /// </summary>
        /// <param name="person">Person object</param>
        /// <param name="type">EType employee status</param>
        /// <param name="id">Employee ID</param>
        protected Employee(Person person, EmployeeType type, int id):
            base(person)
        {
           
            this.Type = type;
            this.Id = id;
            this.Benefits = new EmployeeBenefits
            {
                Benefits = false,
                Compensation = string.Empty,
                Commission = false,
                Overtime = false,
                Education = false,
                Courses = new SortedDictionary<string, Course>()
            };
            position = new Position();
        }

        protected Employee( EmployeeType type, int id)
        {
            // this.Person = person;
            this.Type = type;
            this.Id = id;
            this.Benefits = new EmployeeBenefits
            {
                Benefits = false,
                Compensation = string.Empty,
                Commission = false,
                Overtime = false,
                Education = false,
                Courses = new SortedDictionary<string, Course>()
            };
            position = new Position();
        }

        ///// <summary>
        ///// Gets or sets the <see cref="Person"/> object
        ///// </summary>
        // public Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Employee Type
        /// </summary>
        public EmployeeType Type { get; set; }
        public Position position { get; set; }

        /// <summary>
        /// Gets or sets the Employee ID
        /// </summary>
        public int Id { get; set; }
        public int PositionId { get; set; }
    }
}