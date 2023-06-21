using System.Net;

namespace HelmerDemo.WebShop.Domain.SeedWork.Models
{
    /// <summary>
    /// This class returns a result on a command-type function, for async Task use result as return type, for void use it by instantiating a result, send it along with the void, and set the success etc.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> class.
        /// </summary>
        /// <param name="isSuccess">Indicates a successfull result</param>
        /// <param name="messages">Messages explaining the result </param>
        /// <param name="statusCode">The HttpStatusCode</param>
        public Result(bool isSuccess, List<string> messages, HttpStatusCode statusCode)
        {
            IsSuccess = isSuccess;
            Messages = messages;
            StatusCode = statusCode;
        }

        /// <summary>
        /// Gets or sets if the command was executed successfully, or data was retrieved
        /// </summary>
        public bool IsSuccess { get; private set; }

        /// <summary>
        /// Gets or sets the messages for explaining the result, please use the resx
        /// </summary>
        public IEnumerable<string> Messages { get; private set; }

        /// <summary>
        /// Gets or sets a statuscode defining the Result
        /// </summary>
        public HttpStatusCode StatusCode { get; private set; }
    }
}
