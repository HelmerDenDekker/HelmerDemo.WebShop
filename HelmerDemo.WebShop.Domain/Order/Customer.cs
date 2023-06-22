﻿using HelmerDemo.WebShop.Domain.Shared;

namespace HelmerDemo.WebShop.Domain.Order
{
    /// <summary>
    /// The customer value object for order aggregate
    /// </summary>
    public record Customer
    {
        /// <summary>
        /// Gets the customer number
        /// </summary>
        public int CustomerNumber { get; init; }

        /// <summary>
        /// Gets the customer full name
        /// </summary>
        public string FullName { get; init; } = string.Empty;

        /// <summary>
        /// Gets the billing address
        /// </summary>
        public Address BillingAddress { get; init; }

        /// <summary>
        /// Gets the shipping address
        /// </summary>
        public Address ShippingAddress { get; init; }

        /// <summary>
        /// Gets the shipping option
        /// </summary>
        public ShippingOption ShippingOption { get; init; }

        /// <summary>
        /// Gets the payment option
        /// </summary>
        public PaymentOption PaymentOption { get; init; }
    }
}