using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.Model.DomainModel
{
    public class AuthTokenDM : BaseDomainModel
    {
        #region mapping field
        /// <summary>
        /// get or set 'AuthenticateTokenID'
        /// </summary>
        public int AuthenticateTokenID { get; set; }
        /// <summary>
        /// get or set 'AuthenticateConsumerID'
        /// </summary>
        public int AuthenticateConsumerID { get; set; }
        /// <summary>
        /// get or set 'UserID'
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// get or set 'type' (0 is Dashboard)
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// get or set 'access token'
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// get or set 'Refresh Token'
        /// </summary>
        public string RefreshToken { get; set; }
        /// <summary>
        /// get or set 'Confusion Code'
        /// </summary>
        public string ConfusionCode { get; set; }
        /// <summary>
        /// get or set 'Expiration Date'
        /// </summary>
        public DateTime ExpirationDate { get; set; }
        /// <summary>
        /// get or set 'Expiration Interval'
        /// </summary>
        public decimal ExpirationInterval { get; set; }

        public virtual AuthConsumerDM Consumer { get; set; }
        #endregion mapping field
    }
}
