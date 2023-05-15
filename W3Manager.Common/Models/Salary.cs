namespace EmployeeManagementSystem.Common.Models
{

    /// <summary>
    /// Represents a Salary Employee object
    /// </summary>
    /// <seealso cref="Employee"/>    
    public class Salary : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Salary"/> class with parameter values
        /// </summary>
        /// <param name="person">Person object</param>
        /// <param name="salary">Employee monthly salary</param>
        /// <param name="id">Employee ID</param>
        public Salary(Person person, decimal salary, int id)
            : base(person, EmployeeType.Salary, id)
        {
            this.MonthlySalary = salary;
            this.Benefits.Compensation = "Salary";
            this.Benefits.Overtime = false;
            this.Benefits.Benefits = true;
            this.Benefits.Commission = false;
            this.Benefits.Education = true;
        }

        public Salary( decimal salary, int id)
            : base( EmployeeType.Salary, id)
        {
            this.MonthlySalary = salary;
            this.Benefits.Compensation = "Salary";
            this.Benefits.Overtime = false;
            this.Benefits.Benefits = true;
            this.Benefits.Commission = false;
            this.Benefits.Education = true;
        }

        /// <summary>
        /// Gets or sets the Employee Monthly Salary
        /// </summary>
        public decimal MonthlySalary { get; set; }
    }
}