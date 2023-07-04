using HelmerDemo.WebShop.Domain.SeedWork.Extensions;

namespace HelmerDemo.WebShop.Domain.UnitTest
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void SetKindUtc_Null_ReturnsNull()
        {
            DateTime? input = null;
            DateTime? result = input.SetKindUtc();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetKindUtc_DateNoKind_ReturnsUtcKind()
        {
            DateTime? input = DateTime.Now;
            DateTime? result = input.SetKindUtc();
            Assert.IsNotNull(result);
            /* below is the primary functionality.  if the input did not have a "Kind" set, it gets set to DateTimeKind.Utc */
            Assert.AreEqual(DateTimeKind.Utc, result.Value.Kind);
        }

        [TestMethod]
        public void SetKindUtc_DateUtcKind_ReturnsUtcKind()
        {
            DateTime? input = DateTime.Now;
            DateTime withKindUtcInput = DateTime.SpecifyKind(input.Value, DateTimeKind.Utc);
            DateTime? result = withKindUtcInput.SetKindUtc();
            Assert.IsNotNull(result);
            /* Utc "in" remains "Utc" out */
            Assert.AreEqual(DateTimeKind.Utc, result.Value.Kind);
        }

        [TestMethod]
        public void SetKindUtc_DateUnspecifiedKind_ReturnsUtcKind()
        {
            DateTime? input = DateTime.Now;
            DateTime withKindUtcInput = DateTime.SpecifyKind(input.Value, DateTimeKind.Unspecified);
            DateTime? result = withKindUtcInput.SetKindUtc();
            Assert.IsNotNull(result);
            /* note the behavior.  "DateTimeKind.Unspecified" with overwritten with DateTimeKind.Utc */
            Assert.AreEqual(DateTimeKind.Utc, result.Value.Kind);
        }

        [TestMethod]
        public void SetKindUtc_DateLocalKind_ReturnsUtcKind()
        {
            DateTime? input = DateTime.Now;
            DateTime withKindUtcInput = DateTime.SpecifyKind(input.Value, DateTimeKind.Local);
            DateTime? result = withKindUtcInput.SetKindUtc();
            Assert.IsNotNull(result);
            /* note the behavior.  "DateTimeKind.Local" with overwritten with DateTimeKind.Utc */
            Assert.AreEqual(DateTimeKind.Utc, result.Value.Kind);
        }
    }
}
