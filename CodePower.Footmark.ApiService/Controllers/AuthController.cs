using CodePower.Footmark.ApiBizLogic.Auth;
using CodePower.Footmark.Model.ContractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodePower.Footmark.ApiService.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        private AuthManager _manager;
        public AuthController()
        {
            this._manager = new AuthManager();
        }

        /// <summary>
        /// Get current access token
        /// </summary>
        /// <param name="consumer">consumer entity</param>
        /// <returns></returns>
        [HttpPost]
        [Route("token")]
        public object Token([FromBody]AuthCM model)
        {
            IOAuth auth = _manager.CreateAuthProcess(model);
            object tokenEntity = auth.GenerateAccessToken();
            return tokenEntity;
        }
    }
}
