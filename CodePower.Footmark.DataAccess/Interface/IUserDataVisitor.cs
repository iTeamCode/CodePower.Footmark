using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess
{
    public interface IUserDataVisitor : IDataVisitor
    {
        #region Authentication associated
        /// <summary>
        /// Feach AuthConsumer information.
        /// </summary>
        /// <param name="consumerKey">consumer key</param>
        /// <param name="consumerSecret">consumer secret</param>
        /// <returns>auth consumer entity</returns>
        AuthConsumerDM FeachAuthConsumer(string consumerKey, string consumerSecret);
        /// <summary>
        /// Fetch Auth AccessToken
        /// </summary>
        /// <param name="token">token</param>
        /// <returns>AuthToken</returns>
        AuthTokenDM FetchAuthAccessToken(string token);
        /// <summary>
        /// Update AuthToken
        /// </summary>
        /// <param name="token">token</param>
        void UpdateAuthToken(AuthTokenDM token);
        /// <summary>
        /// Create AuthToken
        /// </summary>
        /// <param name="token">token</param>
        void CreateAuthToken(AuthTokenDM token);
        #endregion Authentication associated
    }
}
