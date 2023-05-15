namespace EmployeeManagementSystem.Common.Models
{
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    /// Represents a person with address and phone number
    /// </summary>    
    public class Person
    {
        public Person(Person person)
        {
            FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.Street = person.Street;
            this.City = person.City;
            this.Phone = person.Phone;
        }
        public Person()
        { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> struct
        /// </summary>
        /// <param name="first">Person first name string</param>
        /// <param name="last">Person last name string</param>
        /// <param name="street">Person address street string</param>
        /// <param name="city">Person address city string</param>
        
        /// <param name="phone">Person phone number (string)</param>
        public Person(
            string first,
            string last,
            string street,
            string city,
            string phone)
        {
            FirstName = first;
            this.LastName = last;
            this.Street = street;
            this.City = city;           
            this.Phone = phone;
        }

        /// <summary>
        /// Gets or sets the Person first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Person last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Address street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets Address City
        /// </summary>
        public string City { get; set; }

       

        /// <summary>
        /// Gets or sets Person phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Returns a string version of the data within the Person object
        /// </summary>
        /// <returns>String representation of Person information</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.FirstName} {this.LastName}");
            sb.AppendLine($"{this.Street}, {this.City}");
            sb.AppendLine($"{this.Phone}");

            return sb.ToString();
        }
    }
}