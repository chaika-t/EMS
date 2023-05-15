namespace EmployeeManagementSystem.ValidationEngine
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Provides the ability to validate single input, or a form using string arrays
    /// </summary>
    /// <inheritdoc cref="IValidationEngine"/>
    public class ValidationEngine : IValidationEngine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationEngine"/> class
        /// </summary>
        public ValidationEngine()
        {
            this.Regex = null;
        }

        /// <summary>
        /// Gets or sets the Regex implementation from IValidate
        /// </summary>
        public Regex Regex { get; set; }

        /// <summary>
        /// Sets the Regex pattern
        /// </summary>
        /// <param name="pattern">String pattern for Regex to use</param>
        public void SetPattern(string pattern)
        {
            this.Regex = new Regex(pattern);
        }

        /// <summary>
        /// Implementation of the IValidate.Validate method. Validates the given input against a Regex pattern.
        /// </summary>
        /// <param name="input">String input to validate against</param>
        /// <returns>Boolean flag if input matches Regex pattern</returns>
        /// <exception cref="NullReferenceException">Thrown if SetPattern isn't called previously (Regex is null)</exception>
        public bool Validate(string input)
        {
            if (this.Regex == null)
            {
                throw new NullReferenceException("Regex is not valid, have you set the pattern?");
            }

            return this.Regex.IsMatch(input);
        }
    }
}
