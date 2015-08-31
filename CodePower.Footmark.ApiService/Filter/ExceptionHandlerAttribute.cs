using CodePower.Framework.Common.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Security.Authentication;
using System.Web;
using System.Web.Http.Filters;

namespace CodePower.Footmark.ApiService.Filter
{
    /// <summary>
    /// Handler api exception
    /// </summary>
    public class ExceptionHandlerAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            //TODO: log it
            //Logging.Logger.Write(context.Exception, Application.SeniorPastorDashboard, LogType.Database);

            if (context.Exception is AuthenticationException)
            {
                var ex = context.Exception as AuthenticationException;
                context.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized)
                {
                    Content = new ObjectContent<object>(new { errorMessage = ex.Message }, new JsonMediaTypeFormatter()),
                    //ReasonPhrase = "Authentication Exception"
                };
                //To DO:: loging exception here.{ context.ActionContext.RequestContext.Principal }
                return;
            }

            if (context.Exception is BusinessException)
            {
                var ex = context.Exception as BusinessException;
                context.Response = new HttpResponseMessage(ex.StatusCode)
                {
                    Content = new ObjectContent<object>(new { errorMessage = ex.Message }, new JsonMediaTypeFormatter()),
                    //ReasonPhrase = "Business Exception"
                };
                //To DO:: loging exception here.{ context.ActionContext.RequestContext.Principal }
                return;
            }

            // not hander error.
            context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new ObjectContent<object>(new { errorMessage = context.Exception.Message }, new JsonMediaTypeFormatter()),
                ReasonPhrase = "InternalServerError"
            };
            //To DO:: loging exception here.{ context.ActionContext.RequestContext.Principal }
        }
    }
}