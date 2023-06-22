namespace HelmerDemo.WebShop.Domain.Order
{
    public record OrderItem
    {
        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; init; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public Product Product { get; init; }

        /// <summary>
        /// Gets the price of the orderitem
        /// </summary>
        public Money Price { get; init; }


        // As a User I want to know the price of my orderitem
    }
}
