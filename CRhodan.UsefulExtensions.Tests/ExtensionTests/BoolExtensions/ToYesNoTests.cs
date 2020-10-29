using CRhodan.UsefulExtensions.Extensions;
using NUnit.Framework;

namespace CRhodan.UsefulExtensions.Tests.ExtensionTests.BoolExtensions
{
    [TestFixture]
    public class ToYesNoTests
    {
        [TestCase(true, "Yes")]
        [TestCase(false, "No")]
        public void ToYesNo_CorrectlyConvertsValue(bool inputValue, string expectedValue)
        {
            Assert.AreEqual(expectedValue, inputValue.ToYesNo());
        }
    }
}