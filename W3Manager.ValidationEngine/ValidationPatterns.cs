namespace EmployeeManagementSystem.ValidationEngine
{
    /// <summary>
    /// Commonly used validation patterns
    /// </summary>
    public struct ValidationPatterns
    {
        /// <summary>
        /// Gets or sets the Regex pattern for validating names (1+ word names)
        /// </summary>
        public string NamePattern { get; set; }

        /// <summary>
        /// Gets or sets the Regex pattern used to validate phone numbers
        /// </summary>
        public string PhonePattern { get; set; }

        /// <summary>
        /// Gets or sets the Regex patter to validate ID
        /// </summary>
        public string IdPattern { get; set; }

        /// <summary>
        /// Gets or sets the Regex pattern to validate U.S. Zip codes
        /// </summary>
        public string ZipPattern { get; set; }

        /// <summary>
        /// Gets or sets the Regex pattern to validate currencies
        /// </summary>
        public string CurrencyPattern { get; set; }

        /// <summary>
        /// Gets or sets the Regex pattern to validate dates
        /// </summary>
        public string DatePattern { get; set; }
    }
}
