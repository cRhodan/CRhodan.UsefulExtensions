using System.Globalization;
using System.Runtime.CompilerServices;

namespace CRhodan.UsefulExtensions.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the supplied object's type as well as the calling method name.
        /// For Example:
        /// this.GetMethodName() returns ExecutingClassName.ExecutingMethodName
        /// string.GetMethodName() returns String.ExecutingMethodName
        /// </summary>
        public static string GetMethodName(this object type, [CallerMemberName] string caller = null)
        {
            return type.GetType().Name + "." + caller;
        }
        
        
        /// <summary>
        /// Attempt to convert the supplied string to Title Case 
        /// </summary>
        /// <param name="input">The string to convert to Title Case</param>
        /// <param name="cultureName">The culture name to use (defaults to En-Au if not supplied)</param>
        /// <returns>The supplied input string in Title Case</returns>
        public static string ToTitleCase(this string input, string cultureName = "en-AU")
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            var textInfo = new CultureInfo(cultureName, false).TextInfo;
            return textInfo.ToTitleCase(input.ToLowerInvariant());
        }
    }
}