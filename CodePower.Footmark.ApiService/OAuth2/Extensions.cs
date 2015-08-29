using CodePower.Footmark.ApiBizLogic.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CodePower.Footmark.ApiService.OAuth2
{
    public static class Extensions
    {
        /// <summary>
        /// Verify request token is available.
        /// </summary>
        /// <param name="request">current request entity.</param>
        /// <param name="user">auth user</param>
        /// <returns>is pass auth</returns>
        public static bool AuthorizationRequest(this HttpRequestMessage request, out AuthUser user)
        {
            bool isPass = false;
            user = null;
            if (request.Headers == null || request.Headers.Authorization == null)
            {
                return isPass;
                //throw new Exception("[HttpRequestException]:requset header is null!");
            }
            //Get 'Authorization access token' from request header.
            string authScheme = request.Headers.Authorization.Scheme;
            string authParameter = request.Headers.Authorization.Parameter;

            if (authScheme == "bearer")
            {
                AuthManager manager = new AuthManager();
                AuthUserFactory userFactory;
                int userId;
                isPass = manager.CreateAuthUserFactory(authParameter, out userFactory, out userId);
                if (isPass)
                {
                    user = userFactory.CreateAuthUser(userId);
                }
            }
            return isPass;
        }
    }
}