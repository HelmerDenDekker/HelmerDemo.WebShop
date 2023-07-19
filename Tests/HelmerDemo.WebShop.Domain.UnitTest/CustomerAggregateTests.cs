using HelmerDemo.WebShop.Domain.CustomerModel;
using HelmerDemo.WebShop.Domain.SeedWork.Extensions;
using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Domain.UnitTest
{
    /// <summary>
    /// The tests for the customer aggregate.
    /// </summary>
    [TestClass]
    public class CustomerAggregateTests
    {
        [TestMethod]
        public void CreateCustomer_HasInvalidEmail_Should_ReturnBadRequest()
        {
            //Arrange
            var fullName = "Test Name";
            var email = "notanemail";
            var customerAggregate = new CustomerAggregate();

            //Act
            var customerResult = customerAggregate.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.BadRequest.DownCast<CustomerEntity>();
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

        [TestMethod]
        public void CreateCustomer_HasEmptyEmail_Should_ReturnBadRequest()
        {
            //Arrange
            var fullName = "Test Name";
            var email = string.Empty;
            var customerAggregate = new CustomerAggregate();

            //Act
            var customerResult = customerAggregate.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.BadRequest.DownCast<CustomerEntity>();
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

        [TestMethod]
        public void CreateCustomer_HasNullEmail_Should_ReturnBadRequest()
        {
            //Arrange
            var fullName = "Test Name";
            string? email = null;
            var customerAggregate = new CustomerAggregate();

            //Act
            var customerResult = customerAggregate.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.BadRequest.DownCast<CustomerEntity>();
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

        [TestMethod]
        public void CreateCustomer_HasWhitespaceEmail_Should_ReturnBadRequest()
        {
            //Arrange
            var fullName = "Test Name";
            string email = " ";
            var customerAggregate = new CustomerAggregate();

            //Act
            var customerResult = customerAggregate.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.BadRequest.DownCast<CustomerEntity>();
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

        [TestMethod]
        public void CreateCustomer_HasValidEmail_Should_ReturnCreatedRequest()
        {
            //Arrange
            var fullName = "Test Name";
            string email = "test@test.com";
            var customerAggregate = new CustomerAggregate();

            //Act
            var customerResult = customerAggregate.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.Created;
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

        [TestMethod]
        public void CreateCustomer_HasValidEmailNoDot_Should_ReturnCreatedRequest()
        {
            //Arrange
            var fullName = "Test Name";
            string email = "test@testcom";
            var customerAggregate = new CustomerAggregate();

            //Act
            var customerResult = customerAggregate.CreateCustomer(fullName, email);

            //Assert
            var expectedResult = Result.Created;
            Assert.AreEqual(expectedResult.StatusCode, customerResult.StatusCode);
        }

    }
}