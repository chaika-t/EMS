namespace EmployeeManagementSystem.Common.Enumerations
{
    /// <summary>
    /// Different format for displaying phone numbers
    /// </summary>
    public static class PhoneDisplayFormats
    {
        /// <summary>
        /// Display phone with dashes between number groups
        /// </summary>
        public const string Dashed = "xxx-xxx-xxxx";

        /// <summary>
        /// Display phone with first group in parenthesis and dash between second and third group
        /// </summary>
        public const string Standard = "(xxx) xxx-xxxx";

        /// <summary>
        /// Display phone with country code and dot between code and number
        /// </summary>
        public const string International = "+1.xxxxxxxxxx";
    }
}
