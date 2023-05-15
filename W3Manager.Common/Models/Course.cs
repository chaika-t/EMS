namespace EmployeeManagementSystem.Common.Models
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a school course
    /// </summary>
    [DataContract]
    public class Course
    {
        public Course() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> struct
        /// </summary>
        /// <param name="id">Course ID</param>
        /// <param name="name">Course Name</param>
        /// <param name="credits">Credit hours provided</param>
        /// <param name="approved">Course approval status</param>
        /// <param name="date">Course approval date</param>
        /// <param name="description">Course Description</param>
        /// <param name="personId">Course ID</param>
        public Course(
            string id,
            int personId,
            string name,
            int credits,
            bool approved,
            string date = "",
            string description = "")
        {
            this.CourseId = id;
            this.CourseName = name;
            this.Description = description;
            this.Credits = credits;
            this.Approved = approved;
            this.ApprovedDate = DateTime.Parse( date);
           this.PersonId = personId;
        }

      
        /// <summary>
        /// Gets or sets the Course ID
        /// </summary>
        public string CourseId { get; set; }

        /// <summary>
        /// Gets or sets the Course Name
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// Gets or sets the Course Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Course Credit Hours
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Course is approved
        /// </summary>
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets the Course Approval Date
        /// </summary>
        public DateTime ApprovedDate { get; set; }
        /// <summary>
        /// Gets or sets the Person ID
        /// </summary>
        public int PersonId { get; set; }
    }
}
