namespace HelmerDemo.WebShop.Domain.Order
{
    public class Order
    {
        public Guid Number { get; private set; }
        public string Status { get; private set; } = string.Empty;

        public DateTime Date { get; private set; }
    }
}
