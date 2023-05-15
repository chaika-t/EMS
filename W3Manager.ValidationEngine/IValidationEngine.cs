namespace EmployeeManagementSystem.ValidationEngine
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Provides basic form validation members used in a validation engine
    /// </summary>
    public interface IValidationEngine
    {
        /// <summary>
        /// Gets or sets the Regex object to be used during validation
        /// </summary>
        Regex Regex { get; set; }

        /// <summary>
        /// Instantiate a new Regex object with the given string pattern
        /// </summary>
        /// <param name="pattern">String Regex pattern to instantiate with</param>
        void SetPattern(string pattern);

        /// <summary>
        /// Validates the given input with a pre-set pattern
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <returns>Boolean flag if input matched pattern</returns>
        bool Validate(string input);
    }
}
