using BankCurrencyService.DTO.ServiceOutputBase;
using Newtonsoft.Json;

namespace BankCurrencyService.Infrastructure.Middlewares
{
    /// <summary>
    /// A middleware to handle errors globally.
    /// This middleware is not complete. I just implement a simple one (without ErrorDescriptor) just for the ASSIGNMENT.
    /// </summary>
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, ILogger<ErrorHandlingMiddleware> logger)
        {
            try
            {
                await _next(context);
            }
            catch (System.Exception ex)
            {
                await HandleExceptionAsync(context, ex, logger);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, System.Exception exception, ILogger logger)
        {
            var errMsg = GenerateResponseText(new ErrorResult { ErrorMessage = exception.Message }); 

            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(errMsg);
        }

        private static string GenerateResponseText(ErrorResult errorResult)
        {
            return JsonConvert.SerializeObject(errorResult);
        }
    }
}
