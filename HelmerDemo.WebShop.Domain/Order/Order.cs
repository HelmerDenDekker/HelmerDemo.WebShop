namespace HelmerDemo.WebShop.Domain.Order
{
    /// <summary>
    /// Order Aggregate
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets the Order Number
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Gets the Order Status
        /// </summary>
        public OrderStatus Status { get; private set; }

        /// <summary>
        /// Gets the Order Date
        /// </summary>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Gets the price of the total order
        /// </summary>
        public Money Price { get; private set; }

        /// <summary>
        /// Gets the order item
        /// </summary>
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        // As a User I want to know the price of my order
    }
}
