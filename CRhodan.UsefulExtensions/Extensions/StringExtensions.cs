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
        /// Attempt to convert the string to Title Case in en-AU.
        /// </summary>
        public static string ToTitleCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            var textInfo = new CultureInfo("en-AU", false).TextInfo;
            return textInfo.ToTitleCase(input.ToLowerInvariant());
        }
    }
}