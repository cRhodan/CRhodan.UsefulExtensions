using CRhodan.UsefulExtensions.Extensions;
using NUnit.Framework;

namespace CRhodan.UsefulExtensions.Tests.ExtensionTests.StringExtensions
{
    [TestFixture]
    public class GetMethodNameTests
    {
        [Test]
        public void CalledOnThis_ShouldReturnMethodName()
        {
            var result = this.GetMethodName();
            Assert.AreEqual(result, "GetMethodNameTests.CalledOnThis_ShouldReturnMethodName");
        }
        
        [Test]
        public void CalledOnObject_ShouldReturnObjectName()
        {
            var testString = "thisString";
            var result = testString.GetMethodName();
            Assert.AreEqual(result, "String.CalledOnObject_ShouldReturnObjectName");
        }
        
    }
}