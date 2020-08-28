using System;
using System.ComponentModel;

namespace CRhodan.UsefulExtensions.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Returns the Description attribute for an Enum if set. If not set, returns the name of the enum as if you had called ToString()
        /// </summary>
        /// <param name="enumValue">The Enumerated value to retrieve the description from</param>
        /// <returns>The Description for the select enumeration value</returns>
        public static string GetDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo == null) return enumValue.ToString();
            
            var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
            return attrs.Length > 0 ? ((DescriptionAttribute) attrs[0]).Description : enumValue.ToString();
        }
    }
}