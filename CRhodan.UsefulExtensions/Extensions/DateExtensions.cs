using System;

namespace CRhodan.UsefulExtensions.Extensions
{
    public static class DateExtensions
    {
        /// <summary>
        /// Calculates a person's age based on their date of birth and a supplied date (usually now, but not necessarily)
        /// </summary>
        /// <param name="dateOfBirth">The person's date of birth</param>
        /// <param name="at">The date to calculate their age at</param>
        /// <returns>Their age</returns>
        /// <exception cref="ArgumentOutOfRangeException">If the date of calculation is before their date of birth</exception>
        public static int GetAge(this DateTime dateOfBirth, DateTime at)
        {
            if(at < dateOfBirth) throw new ArgumentOutOfRangeException(nameof(at), "Date to check age at cannot be before their date of birth");

            var alreadyHadBirthday = dateOfBirth.Month < at.Month || dateOfBirth.Month == at.Month && dateOfBirth.Day <= at.Day;

            var age = at.Year - dateOfBirth.Year;

            if (!alreadyHadBirthday) age--;

            return age;
        }
    }
}