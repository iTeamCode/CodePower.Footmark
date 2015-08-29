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
        /// get or set 'SysNo'
        /// </summary>
        public int SysNo { get; set; }
        /// <summary>
        /// get or set 'AuthConsumerSysNo'
        /// </summary>
        public int AuthConsumerSysNo { get; set; }
        /// <summary>
        /// get or set 'UserID'
        /// </summary>
        public int UserSysNo { get; set; }
        /// <summary>
        /// get or set 'type' (0 is Dashboard)
        /// </summary>
        public int TypeId { get; set; }
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
        /// get or set 'Expiration Time'
        /// </summary>
        public DateTime ExpirationTime { get; set; }
        /// <summary>
        /// get or set 'Expiration Interval'
        /// </summary>
        public decimal ExpirationInterval { get; set; }

        public virtual AuthConsumerDM Consumer { get; set; }
        #endregion mapping field
    }
}
