namespace HelmerDemo.WebShop.Domain.OrderModel
{
    /// <summary>
    /// Order Aggregate
    /// </summary>
    public class OrderEntity
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
        public MoneyVO Price { get; private set; }

        /// <summary>
        /// Gets the order item
        /// </summary>
        public List<OrderItemVO> Items { get; private set; } = new List<OrderItemVO>();

        // As a User I want to know the price of my order
    }
}
