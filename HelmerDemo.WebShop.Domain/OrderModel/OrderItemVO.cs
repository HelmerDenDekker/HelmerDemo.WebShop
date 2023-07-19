namespace HelmerDemo.WebShop.Domain.OrderModel
{
    public record OrderItemVO
    {
        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; init; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public ProductVO Product { get; init; }

        /// <summary>
        /// Gets the price of the orderitem
        /// </summary>
        public MoneyVO Price { get; init; }


        // As a User I want to know the price of my orderitem
    }
}
