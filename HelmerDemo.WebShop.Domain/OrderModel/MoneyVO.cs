namespace HelmerDemo.WebShop.Domain.OrderModel
{
    /// <summary>
    /// Money value object for order aggregate
    /// </summary>
    public record MoneyVO
    {
        /// <summary>
        /// Gets the currency
        /// </summary>
        public string Currency { get; init; } = string.Empty;

        /// <summary>
        /// Gets the amount
        /// </summary>
        public decimal Amount { get; init; }
    }
}
