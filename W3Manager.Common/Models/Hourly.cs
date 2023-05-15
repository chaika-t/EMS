namespace EmployeeManagementSystem.Common.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents an Hourly Employee
    /// </summary>
    /// <seealso cref="Employee"/>   
    public sealed class Hourly : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hourly"/> class
        /// </summary>
        /// <param name="person">Person object</param>
        /// <param name="wage">Wage value</param>
        /// <param name="hours">Hours worked value</param>
        /// <param name="id">Employee ID value</param>
        public Hourly(Person person, decimal wage, decimal hours, int id)
            : base(person, EmployeeType.Hourly, id)
        {
            this.HourlyRate = wage;
            this.Hours = hours;          
            this.Benefits.Compensation = "Hourly Rate";
            this.Benefits.Overtime = true;
            this.Benefits.Education = true;
        }

        /// <summary>
        /// Gets or sets the Employee's Hourly Rate
        /// </summary>
        public decimal HourlyRate { get; set; }

        /// <summary>
        /// Gets or sets the Employee's hours worked
        /// </summary>
        public decimal Hours { get; set; }
    }
}