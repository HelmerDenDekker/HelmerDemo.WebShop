namespace HelmerDemo.WebShop.Presentation.Models
{
    /// <summary>
    /// The Http response header settings
    /// </summary>
    public class HeaderSettings
    {
        /// <summary>
        /// Gets or sets a custom content security policy
        /// </summary>
        public string ContentSecurityPolicy { get; set; } = string.Empty;
    }
}
