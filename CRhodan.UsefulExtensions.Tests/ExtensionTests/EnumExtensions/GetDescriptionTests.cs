using CRhodan.UsefulExtensions.Extensions;
using NUnit.Framework;

namespace CRhodan.UsefulExtensions.Tests.ExtensionTests.EnumExtensions
{

    [TestFixture]
    public class GetDescriptionTests
    {
        [Test]
        public void ValueWithDescription_ShouldReturnDescription()
        {
            var result = Constants.TestEnum.One.GetDescription();
            Assert.AreEqual(result, "Test Description for One");
        }

        [Test]
        public void ValueWithoutDescription_ShouldReturnName()
        {
            var result = Constants.TestEnum.Two.GetDescription();
            Assert.AreEqual(result, "Two");
        }
    }
}