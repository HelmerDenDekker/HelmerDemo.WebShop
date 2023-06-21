using HelmerDemo.WebShop.Domain.SeedWork.Models;
using System.Net;

namespace HelmerDemo.WebShop.Domain.SeedWork.Helpers
{
    /// <summary>
    /// Defines standardized results for use in code
    /// </summary>
    public static class StandardResult
    {
        /// <summary>
        /// Request passed, data is in the result class. Equivalent to 200 OK.
        /// </summary>
        public static Result Ok => new( true, new List<string> { "The request succeeded and the requested information is in the response" }, HttpStatusCode.OK );

        /// <summary>
        /// Request passed, a new resource was successfully created. Equivalent to 201 Created.
        /// </summary>
        public static Result Created => new(true, new List<string> { "A new resource was successfully created" }, HttpStatusCode.Created);

        /// <summary>
        /// Request passed, the request has been successfully processed. Equivalent to 204 NoContent.
        /// </summary>
        public static Result NoContent => new(true, new List<string> { "The request has been successfully processed" }, HttpStatusCode.NoContent);

        /// <summary>
        /// Request failed, the request cannot be processeed by the code. Equivalent to 409 conflict
        /// </summary>
        public static Result Conflict => new(false, new List<string> { "The request cannot be processeed by the code due to a conflict" }, HttpStatusCode.Conflict);

        /// <summary>
        /// Request failed, the request cannot be processed by the code. Equivalent to 400 Bad Request.
        /// </summary>
        public static Result BadRequest => new(false, new List<string> { "The request cannot be processed by the code due to a validation error" }, HttpStatusCode.BadRequest);

        /// <summary>
        /// Request failed, the request cannot be processed by the code. Equivalent to 401 Unauthorized.
        /// </summary>
        public static Result UnAuthorized => new(false, new List<string> { "The request cannot be processed by the code, no authorization" }, HttpStatusCode.Unauthorized);

        /// <summary>
        /// Request failed, the resource cannot be found by the code. Equivalent to 404 Not found.
        /// </summary>
        public static Result NotFound => new(false, new List<string> { "The resource cannot be found by the code" }, HttpStatusCode.NotFound);

        /// <summary>
        /// Request failed, an insecure url address is used (http:// instead of https://) Refers to 451, in the meaning that this resource is not available due to legal reasons (gdpr)
        /// </summary>
        public static Result InsecureUrl => new(false, new List<string> { "The request cannot be processed by the server, due to an insecure url address being used." }, HttpStatusCode.UnavailableForLegalReasons);

        /// <summary>
        /// Request failed, a generic error occured. Equivalent to 500 Internal server error.
        /// </summary>
        public static Result InternalServerError => new(false, new List<string> { "The request cannot be processed by the server. A generic error has occured." }, HttpStatusCode.InternalServerError);

        /// <summary>
        /// Request failed, the code is not implemented. Equivalent to 501 NotImplemented.
        /// </summary>
        public static Result NotImplemented => new(false, new List<string> { "The request cannot be processed by the server. This funcionality is not implemented" }, HttpStatusCode.NotImplemented);
    }
}
