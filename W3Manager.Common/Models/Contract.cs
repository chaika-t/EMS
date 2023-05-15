namespace EmployeeManagementSystem.Common.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a Contract Employee
    /// </summary>
    /// <seealso cref="Employee"/>
    [DataContract]
    public sealed class Contract : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract"/> class
        /// </summary>
        /// <param name="person">Person object</param>
        /// <param name="wage">Contract wage value</param>
        /// <param name="id">Employee ID value</param>
        public Contract(Person person, decimal wage, int id)
            : base(person, EmployeeType.Contract, id)
        {
            this.ContractWage = wage;
            this.Benefits.Compensation = "Monthly Pay";           
        }

        /// <summary>
        /// Gets or sets the Employee's Contract wage
        /// </summary>
        public decimal ContractWage { get; set; }
    }
}