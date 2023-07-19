using HelmerDemo.WebShop.Infrastructure.CustomerModel;
using Moq;

namespace HelmerDemo.WebShop.Application.UnitTest
{
    // Use a mock for CustomerAggregate and a mock for the Repository (Query / Command!!)
    [TestClass]
    public class CustomerServiceUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ToDo write the test
            // Arrange
            var customerRepositoryMock = new Mock<ICustomerRepository>();
            var customerRepository = customerRepositoryMock.Object;
            var newCustomer = new Customer(Guid.NewGuid(), DateTime.Now, "Test the Tester", "testemail@testdomain.com");

            // Act

            //ToDo

            // Assert

            // Verify that this method was called. From here on into other dependencies is not our problem.
            customerRepositoryMock.Verify(repo => repo.CreateCustomer(It.IsAny<Customer>()));
        }
    }
}