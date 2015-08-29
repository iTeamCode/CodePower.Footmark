using CodePower.Footmark.ApiBizLogic.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Http.Results;

namespace CodePower.Footmark.ApiService.OAuth2
{
    /// <summary>
    /// authenticate token to controllers or action.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthenticateAttribute : FilterAttribute, IAuthenticationFilter
    {
        /// <summary>
        /// authenticate async.
        /// </summary>
        /// <param name="context">context</param>
        /// <param name="cancellationToken">cancellationToken</param>
        /// <returns>task object</returns>
        public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            //Get 'access token' from user request.
            IPrincipal user = null;
            AuthUser authUser;
            if (context.Request.AuthorizationRequest(out authUser))
            {
                //token is available. 
                var userInfo = authUser.User;
                OAuthIdentity identity = new OAuthIdentity(authUser);
                user = new GenericPrincipal(identity, new string[0]);
            }
            context.Principal = user;
            return Task.FromResult<object>(null);
        }
        /// <summary>
        /// challenge function.
        /// </summary>
        /// <param name="context">context</param>
        /// <param name="cancellationToken">cancellation token</param>
        /// <returns>task object</returns>
        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            IPrincipal user = context.ActionContext.ControllerContext.RequestContext.Principal;
            if (user == null || !user.Identity.IsAuthenticated)
            {
                //token is unavailable, repsone the Unauthorized(401).
                string parameter = string.Format("realm=\"{0}\"", context.Request.RequestUri.DnsSafeHost);
                AuthenticationHeaderValue challenge = new AuthenticationHeaderValue("Basic", parameter);
                context.Result = new UnauthorizedResult(new AuthenticationHeaderValue[] { challenge }, context.Request);
            }
            return Task.FromResult<object>(null);
        }
    }
}