using CRhodan.UsefulExtensions.Extensions;
using NUnit.Framework;

namespace CRhodan.UsefulExtensions.Tests.ExtensionTests.StringExtensions
{
    [TestFixture]
    public class TitleCaseTests
    {
        [TestCase("one example string", "One Example String")]
        [TestCase("one Example string", "One Example String")]
        [TestCase("one Example String", "One Example String")]
        [TestCase("One Example String", "One Example String")]
        [TestCase("", "")]
        [TestCase("headingIsOneWord", "Headingisoneword")]
        [TestCase("HeadingIsOneWord", "Headingisoneword")]
        [TestCase("Different String", "Different String")]
        [TestCase("different string", "Different String")]
        public void ShouldConvertInputStringToTitleCase(string input, string expected)
        {
            var result = input.ToTitleCase();
            Assert.AreEqual(result, expected);
        }
    }
}