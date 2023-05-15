namespace EmployeeManagementSystem.Common.Extensions
{
    using System.Globalization;

    
    public static class StringExtensions
    {
       
        public static string FormatInvariant(this string baseString, params object[] args)
        {
            return string.Format(CultureInfo.InvariantCulture, baseString, args);
        }
    }
}
