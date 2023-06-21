using HelmerDemo.WebShop.Application.Helpers;
using System.Reflection;

namespace HelmerDemo.WebShop.Application.UnitTest
{
    [TestClass]
    public class ApplicationVersionTests
    {
        [TestMethod]
        public void ApplicationVersion_Returns_AssemblyVersionNumber()
        {
            //Arrange
            var assembly = typeof(ApplicationVersion).GetTypeInfo().Assembly;
            var number = assembly.GetName().Version?.ToString();
            
            //Act

            var applicationVersion = new ApplicationVersion();

            //Assert
            Assert.IsNotNull(applicationVersion.Number);
            Assert.AreEqual(number, applicationVersion.Number);
        }

        [TestMethod]
        public void ApplicationVersion_Returns_AssemblyVersionName()
        {
            //Arrange
            var assembly = typeof(ApplicationVersion).GetTypeInfo().Assembly;
            var name = assembly.GetName().Name?.ToString();

            //Act

            var applicationVersion = new ApplicationVersion();

            //Assert
            Assert.IsNotNull(applicationVersion.Name);
            Assert.AreEqual(name, applicationVersion.Name);
        }
    }
}