using System.Reflection;

namespace HelmerDemo.WebShop.Application.Helpers
{
    public class ApplicationVersion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationVersion"/> class.
        /// </summary>
        public ApplicationVersion()
        {
            var number = Assembly.GetExecutingAssembly()?.GetName().Version?.ToString();
            this.Number = number??=string.Empty;
            var name = Assembly.GetExecutingAssembly()?.GetName().Name?.ToString();
            this.Name = name??=string.Empty;
        }

        /// <summary>
        /// Gets the version number in the form x.y.z.buildnumber
        /// </summary>
        public string Number { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the description of the version
        /// </summary>
        public string Name { get; private set; } = string.Empty;


    }
}
