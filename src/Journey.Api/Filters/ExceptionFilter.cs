using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Journey.Api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var journeyException = (JourneyException)context.Exception;
            if(context.Exception is JourneyException)
            {
                context.HttpContext.Response.StatusCode = (int)journeyException.GetStatusCode();
                context.Result = new ObjectResult(context.Exception.Message);
            }
            else
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Result = new ObjectResult(ResourceErrorMessages.UNKNOWN_ERROR);
            }
        }
    }
}
