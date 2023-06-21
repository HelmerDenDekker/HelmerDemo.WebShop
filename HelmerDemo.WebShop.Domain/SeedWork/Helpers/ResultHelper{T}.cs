using HelmerDemo.WebShop.Domain.SeedWork.Models;

namespace HelmerDemo.WebShop.Domain.SeedWork.Helpers
{
    /// <summary>
    /// An generic extension helper for the Result<typeparamref name="T"/> class.
    /// </summary>
    /// <typeparam name="T">The type of the Result<typeparamref name="T"/> to be returned.</typeparam>
    public static class ResultHelper<T>
        where T : class
    {
        /// <summary>
        /// Downcast from the Result superclass to the Result<typeparamref name="T"/> subclass
        /// </summary>
        /// <param name="result">The Result to be downcasted</param>
        /// <returns>A downcasted Result<typeparamref name="T"/> </returns>
        public static Result<T> DownCast(Result result)
        {
            return new Result<T> ( result.IsSuccess, result.Messages.ToList<string>(), result.StatusCode);
        }
    }
}
