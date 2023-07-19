namespace HelmerDemo.WebShop.Domain.OrderModel
{
    public record ProductVO
    {
        /// <summary>
        /// Gets the product number
        /// </summary>
        public int Number { get; init; }

        /// <summary>
        /// Gets the product name
        /// </summary>
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets the price of the product
        /// </summary>
        public MoneyVO Price { get; init; }
    }
}
