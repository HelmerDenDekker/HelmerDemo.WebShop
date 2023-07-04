using HelmerDemo.WebShop.Domain.SeedWork.Extensions;

namespace HelmerDemo.WebShop.Domain.UnitTest
{
    [TestClass]
    public class StringExtensionsUnitTests
    {
        [TestMethod]
        public void CombineUrls_CorrectFormedUrls_IsWellFormedUriString()
        {
            // Arrange
            var firstPart = "localhost:1234/";
            string goodSecondPart = "/v1/users";

            // Act
            var goodCombinedUrl = firstPart.CombineUrls(goodSecondPart);

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.
            Assert.IsFalse(goodCombinedUrl.Contains("//"));
            Assert.IsNotNull(goodCombinedUrl);
            Assert.IsTrue(Uri.IsWellFormedUriString(goodCombinedUrl, 0));
            //ToDo What do you expect? Because now we are testing IsWellFormedUriString as well
        }

        [TestMethod]
        public void CombineUrls_EscapedUrls_NotIsWellFormedUriString()
        {
            // Arrange
            var firstPart = "localhost:1234/";
            string badSecondPart = "\\/v1/users";

            // Act
            var badCombinedUrl = firstPart.CombineUrls(badSecondPart);

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.

            Assert.IsFalse(badCombinedUrl.Contains("//"));
            Assert.IsNotNull(badCombinedUrl);
            Assert.IsFalse(Uri.IsWellFormedUriString(badCombinedUrl, 0));
        }

        [TestMethod]
        public void CombineUrls_UrlsWithoutSlashes_IsWellFormedUriString()
        {
            // Arrange
            var firstPart = "localhost:1234";
            string secondPart = "v1/users";

            // Act
            var combinedUrl = firstPart.CombineUrls(secondPart);

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.
            Assert.IsTrue(Uri.IsWellFormedUriString(combinedUrl, 0));
        }

        [TestMethod]
        public void CombineUrls_FirstUrlWithoutSlash_IsWellFormedUriString()
        {
            // Arrange
            var firstPart = "localhost:1234";
            string secondPart = "/v1/users";

            // Act
            var combinedUrl = firstPart.CombineUrls(secondPart);

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.

            Assert.IsNotNull(combinedUrl);
            Assert.IsTrue(Uri.IsWellFormedUriString(combinedUrl, 0));
        }

        [TestMethod]
        public void CombineUrls_SecondUrlWithoutSlash_IsWellFormedUriString()
        {
            // Arrange
            var firstPart = "localhost:1234/";
            string secondPart = "v1/users";

            // Act
            var combinedUrl = firstPart.CombineUrls(secondPart);

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.

            Assert.IsNotNull(combinedUrl);
            Assert.IsTrue(Uri.IsWellFormedUriString(combinedUrl, 0));
        }

        [TestMethod]
        public void IsValidEmail_ValidEmail_Should_ReturnTrue()
        {
            // Arrange
            var email = "test@test.com";

            // Act
            var isValidEmail = email.IsValidEmail();

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.

            Assert.IsNotNull(isValidEmail);
            Assert.IsTrue(isValidEmail);
        }

        [TestMethod]
        public void IsValidEmail_String_Should_ReturnFalse()
        {
            // Arrange
            var email = "notanemail";

            // Act
            var isValidEmail = email.IsValidEmail();

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.

            Assert.IsNotNull(isValidEmail);
            Assert.IsFalse(isValidEmail);
        }

        [TestMethod]
        public void IsValidEmail_StringWithDot_Should_ReturnFalse()
        {
            // Arrange
            var email = "notanemail.com";

            // Act
            var isValidEmail = email.IsValidEmail();

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.

            Assert.IsNotNull(isValidEmail);
            Assert.IsFalse(isValidEmail);
        }

        [TestMethod]
        public void IsValidEmail_StringWithDotAndTwoAtts_Should_ReturnFalse()
        {
            // Arrange
            var email = "notanemail@@valid.com";

            // Act
            var isValidEmail = email.IsValidEmail();

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.

            Assert.IsNotNull(isValidEmail);
            Assert.IsFalse(isValidEmail);
        }

        [TestMethod]
        public void IsValidEmail_EmptyString_Should_ReturnFalse()
        {
            // Arrange
            var email = string.Empty;

            // Act
            var isValidEmail = email.IsValidEmail();

            // Assert
            // Asserting URI uses 0 to test for both absolute & reative URI kinds
            // Because method is ambiguous between these two.

            Assert.IsNotNull(isValidEmail);
            Assert.IsFalse(isValidEmail);
        }
    }
}
