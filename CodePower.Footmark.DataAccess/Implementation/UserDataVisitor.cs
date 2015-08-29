using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess.Implementation
{
    public class UserDataVisitor : IUserDataVisitor
    {
        public CurrentUserDM CurrentUser { get; set; }

        #region Data access option
        /// <summary>
        /// Feach AuthConsumer information.
        /// </summary>
        /// <param name="consumerKey">consumer key</param>
        /// <param name="consumerSecret">consumer secret</param>
        /// <returns>auth consumer entity</returns>
        public AuthConsumerDM FeachAuthConsumer(string consumerKey, string consumerSecret)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Fetch Auth AccessToken
        /// </summary>
        /// <param name="token">token</param>
        /// <returns>AuthToken</returns>
        public AuthTokenDM FetchAuthAccessToken(string token)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Create auth token
        /// </summary>
        /// <param name="token"></param>
        public void CreateAuthToken(AuthTokenDM token)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update AuthToken
        /// </summary>
        /// <param name="token">token</param>
        public void UpdateAuthToken(AuthTokenDM token)
        {
            throw new NotImplementedException();
        }
        #endregion Data access option


        
    }
}
