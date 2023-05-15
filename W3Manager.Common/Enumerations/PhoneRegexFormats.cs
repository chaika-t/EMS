namespace EmployeeManagementSystem.Common.Enumerations
{
    /// <summary>
    /// Represents the available phone patterns to validate with
    /// </summary>
    public static class PhoneRegexFormats
    {
        /// <summary>
        /// Phone pattern marked by dots (e.g. xxx.xxx.xxxx)
        /// </summary>
        public static string DotFormat => @"^(\d{3}\.){2}\d{4}$";

        /// <summary>
        /// Phone pattern marked by dashes (e.g. xxx-xxx-xxxx)
        /// </summary>
        public static string DashFormat => @"^(\d{3}\-){2}\d{4}$";

        /// <summary>
        /// Commonly used phone pattern (e.g. (xxx) xxx-xxxx)
        /// </summary>
        public static string StandardFormat => @"^\(\d{3}\)\s\d{3}\-\d{4}$";

        /// <summary>
        /// International phone pattern with U.S. country code (e.g. +1.xxxxxxxxxx)
        /// </summary>
        public static string InternationalFormat => @"^\+1\.\d{10}$";
    }
}
