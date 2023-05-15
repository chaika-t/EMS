namespace EmployeeManagementSystem.Common.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Provides flags for benefits and a educational course dictionary
    /// </summary>
    [DataContract (Name = "Benefits")]
    public struct EmployeeBenefits
    {
        /// <summary>
        /// Employee work compensation
        /// </summary>
        [DataMember] public string Compensation;

        /// <summary>
        /// Flag for if Employee can earn overtime
        /// </summary>
        [DataMember(EmitDefaultValue = false)] public bool Overtime;

        /// <summary>
        /// Flag for if Employee has benefits
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "InsuranceBenefits")] public bool Benefits;

        /// <summary>
        /// Flag for if Employee qualifies for educational benefits
        /// </summary>
        [DataMember(EmitDefaultValue = false)] public bool Education;

        /// <summary>
        /// Flag for if Employee can earn commission
        /// </summary>
        [DataMember(EmitDefaultValue = false)] public bool Commission;

        /// <summary>
        /// Dictionary containing all Courses taken by Employee
        /// </summary>
        [DataMember] public SortedDictionary<string, Course> Courses;
    }
}
