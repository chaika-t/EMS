namespace EmployeeManagementSystem.Common.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a Sales Salaried Employee
    /// </summary>
    /// <seealso cref="Salary"/>
    /// <seealso cref="Employee"/>   
    public sealed class Sales : Salary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sales"/> class
        /// </summary>
        /// <param name="person">Person object</param>
        /// <param name="salary">Employee monthly salary</param>
        /// <param name="salesCommission">Employee commission rate</param>
        /// <param name="sales">Employee gross sales</param>
        /// <param name="id">Employee ID</param>
        public Sales(Person person, decimal salary, decimal salesCommission, decimal sales, int id)
            : base(person, salary, id)
        {
            this.SalesCommission = salesCommission;
            this.GrossSales = sales;           
            this.Benefits.Commission = true;
        }
        public Sales( decimal salary, decimal salesCommission, decimal sales, int id)
            : base( salary, id)
        {
            this.SalesCommission = salesCommission;
            this.GrossSales = sales;
            this.Benefits.Commission = true;
        }
        /// <summary>
        /// Gets or sets the Employee commission rate
        /// </summary>
        public decimal SalesCommission { get; set; }

        /// <summary>
        /// Gets or sets the Employee gross sales
        /// </summary>
        public decimal GrossSales { get; set; }
    }
}