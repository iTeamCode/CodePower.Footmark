using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.Model.ContractModel
{
    /// <summary>
    /// Authentication and authorization contract model.
    /// </summary>
    public class AuthCM
    {
        /// <summary>
        /// get or set 'consumer key'
        /// </summary>
        public string ConsumerKey { get; set; }
        /// <summary>
        /// get or set 'consumer secret'
        /// </summary>
        public string ConsumerSecret { get; set; }
        /// <summary>
        /// get or set 'refresh token'
        /// </summary>
        public string RefreshToken { get; set; }
        /// <summary>
        /// get or set 'grant type'
        /// </summary>
        public string GrantType { get; set; }
        /// <summary>
        /// get or set 'user name'
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// get or set 'password'
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// get or set 'church code'
        /// </summary>
        public string ChurchCode { get; set; }

        /// <summary>
        /// get or set 'confusion code'
        /// </summary>
        public string ConfusionCode { get; set; }
    }

    public class GrantType
    {
        public const string RESOURCE_OWNER_PASSWORD_CREDENTIALS = "password";
        public const string CLIENT_CREDENTIALS = "client_credentials";
        public const string REFRESH_TOKEN = "refresh_token";
    }
}
