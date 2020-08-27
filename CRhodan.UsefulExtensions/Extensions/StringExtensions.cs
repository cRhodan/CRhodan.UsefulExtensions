using System.Runtime.CompilerServices;

namespace CRhodan.UsefulExtensions.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the currently executing Method's name - like nameof(MethodName) but more robust.
        /// Usage is this.GetMethodName()
        /// </summary>
        public static string GetMethodName(this object type, [CallerMemberName] string caller = null)
        {
            return type.GetType().FullName + "." + caller;
        }
    }
}