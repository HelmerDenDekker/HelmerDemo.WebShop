using HelmerDemo.WebShop.Domain.CustomerModel;
using HelmerDemo.WebShop.Domain.SeedWork.Extensions;
using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Domain.UnitTest
{
    [TestClass]
    public class CustomerAggregateTests
    {
        [TestMethod]
        public void Customer_HasInvalidEmail_Should_ReturnBadRequest()
        {
            //Arrange
            var fullName = "Test Name";
            var email = "notanemail";

            //Act
            var customerResult = Customer.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.BadRequest.DownCast<Customer>();
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

        [TestMethod]
        public void Customer_HasEmptyEmail_Should_ReturnBadRequest()
        {
            //Arrange
            var fullName = "Test Name";
            var email = string.Empty;

            //Act
            var customerResult = Customer.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.BadRequest.DownCast<Customer>();
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

        [TestMethod]
        public void Customer_HasNullEmail_Should_ReturnBadRequest()
        {
            //Arrange
            var fullName = "Test Name";
            string? email = null;

            //Act
            var customerResult = Customer.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.BadRequest.DownCast<Customer>();
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

        [TestMethod]
        public void Customer_HasWhitespaceEmail_Should_ReturnBadRequest()
        {
            //Arrange
            var fullName = "Test Name";
            string email = " ";

            //Act
            var customerResult = Customer.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.BadRequest.DownCast<Customer>();
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

        [TestMethod]
        public void Customer_HasValidEmail_Should_ReturnOkRequest()
        {
            //Arrange
            var fullName = "Test Name";
            string email = "test@test.com";

            //Act
            var customerResult = Customer.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.Ok;
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }
    }
}