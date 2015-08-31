using CodePower.Footmark.ApiBizLogic.Auth;
using CodePower.Footmark.ApiService.Filter;
using CodePower.Footmark.ApiService.OAuth2;
using CodePower.Footmark.Model.DomainModel;
using CodePower.Framework.Common.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodePower.Footmark.ApiService.Controllers
{
    /// <summary>
    /// Base controller for api service.
    /// </summary>
    [Authenticate, ExceptionHandler]
    public class BaseController : ApiController
    {
        /// <summary>
        /// current user
        /// </summary>
        private CurrentUserDM _currentUser;
        /// <summary>
        /// Consumer App
        /// </summary>
        private ConsumerApp _consumer;
        /// <summary>
        /// Authorization for current user
        /// </summary>
        private Dictionary<int, string> _authorization;

        /// <summary>
        /// get authenticate user.
        /// </summary>
        protected CurrentUserDM CurrentUser
        {
            get
            {
                if (_currentUser == null)
                {
                    InitCurrentUserInformation();
                }
                return _currentUser;
            }
        }

        protected ConsumerApp Consumer
        {
            get
            {
                if (_consumer == ConsumerApp.Unknow)
                {
                    InitCurrentUserInformation();
                }
                return _consumer;
            }
        }

        protected Dictionary<int, string> Authorization
        {
            get
            {
                if (_authorization == null)
                {
                    InitCurrentUserInformation();
                }
                return _authorization;
            }
        }

        private void InitCurrentUserInformation()
        {
            if (this.User == null || !(this.User.Identity is OAuthIdentity))
            {
                throw new BusinessException("can't get current user information", HttpStatusCode.Unauthorized);
            }

            var user = this.User.Identity as OAuthIdentity;
            //set _currentUser
            this._currentUser = new CurrentUserDM()
            {
                SysNo = user.UserId,
                UserName = user.UserName,
                ChurchId = user.ChurchId,
                ChurchCode = user.ChurchCode
            };

            this._consumer = user.Consumer;             //set _consumer
            this._authorization = user.Authorization;   //set _authorization
        }
    }
}
