using System.Net;

namespace HelmerDemo.WebShop.Domain.SeedWork.Models
{
    /// <summary>
    /// his class returns a result on a query-type function
    /// </summary>
    /// <typeparam name="T">Any class returning information</typeparam>
    public class Result<T> : Result
        where T : class
    {
        public Result(bool isSuccess, List<string> messages, HttpStatusCode statusCode) : base(isSuccess, messages, statusCode)
        {
        }

        /// <summary>
        /// Gets or sets the model filled with the values returning the results
        /// </summary>
        public T Value { get; set; }
    }
}
