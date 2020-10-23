using System;
using CRhodan.UsefulExtensions.Extensions;
using NUnit.Framework;

namespace CRhodan.UsefulExtensions.Tests.ExtensionTests.DateExtensions
{
    [TestFixture]
    public class GetAgeTests
    {
        [Test]
        public void SuppliedDateBeforeDateOfBirth_ThrowException()
        {
            var dateOfBirth = DateTime.Now.AddDays(-1);
            var currentTime = DateTime.Now.AddDays(-2);

            Assert.Throws<ArgumentOutOfRangeException>(() => dateOfBirth.GetAge(currentTime));
        }
        
        [TestCase("01/01/2018", "01/02/2018", 0)]
        [TestCase("02/02/2018", "02/01/2019", 0)]
        [TestCase("02/02/2018", "02/02/2019", 1)]
        [TestCase("02/02/2018", "02/03/2019", 1)]
        [TestCase("12/11/1989", "12/25/2019", 30)]
        [TestCase("12/11/1989", "12/25/2019", 30)]
        [TestCase("12/11/1989", "12/11/2020", 31)]
        public void GetAge(DateTime dateOfBirth, DateTime suppliedDate, int expectedAge)
        {
            var age = dateOfBirth.GetAge(suppliedDate);
            Assert.AreEqual(expectedAge, age);
        }
    }
}