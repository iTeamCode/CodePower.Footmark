using CodePower.Footmark.ApiBizLogic.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace CodePower.Footmark.ApiService.OAuth2
{
    /// <summary>
    /// Identity for OAuth.
    /// </summary>
    public class OAuthIdentity : IIdentity
    {
        private int _id;
        private string _name;
        private int _churchId;
        private string _churchCode;

        private ConsumerApp _consumer;
        private Dictionary<int, string> _authorization;

        public OAuthIdentity(int id, string name, int churchId, string churchCode)
        {
            _id = id;
            _name = name;
            _churchId = churchId;
            _churchCode = churchCode;
        }
        public OAuthIdentity(AuthUser authUser)
        {
            _id = authUser.User.UserId;
            _name = authUser.User.UserName;
            _churchId = authUser.User.ChurchId;
            _churchCode = authUser.User.ChurchCode;

            _consumer = authUser.Consumer;
            _authorization = authUser.Authorization;
        }

        /// <summary>
        /// get 'user id'
        /// </summary>
        public int UserId { get { return this._id; } }

        /// <summary>
        /// get 'church Id'
        /// </summary>
        public int ChurchId { get { return this._churchId; } }

        /// <summary>
        /// get 'user name'
        /// </summary>
        public string UserName { get { return this._name; } }

        /// <summary>
        /// get 'church code'
        /// </summary>
        public string ChurchCode { get { return this._churchCode; } }

        /// <summary>
        /// get 'consumer app'
        /// </summary>
        public ConsumerApp Consumer { get { return this._consumer; } }

        /// <summary>
        /// get 'Authorization'
        /// </summary>
        public Dictionary<int, string> Authorization { get { return this._authorization; } }

        #region for IIdentity
        public string AuthenticationType
        {
            get { return "OAuth2:Resource Owner Password Credentials"; }
        }

        public bool IsAuthenticated
        {
            get { return !string.IsNullOrEmpty(_name); }
        }

        public string Name
        {
            get { return _name; }
        }
        #endregion
    }
}