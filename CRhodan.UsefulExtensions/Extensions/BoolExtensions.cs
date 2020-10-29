namespace CRhodan.UsefulExtensions.Extensions
{
    public static class BoolExtensions
    {
        /// <summary>
        /// Takes a supplied boolean value and returns "Yes" for true or "No" for false
        /// </summary>
        /// <param name="value">The Supplied Boolean value</param>
        /// <returns>Yes if true, No if false</returns>
        public static string ToYesNo(this bool value)
        {
            return value ? "Yes" : "No";
        }
    }
}