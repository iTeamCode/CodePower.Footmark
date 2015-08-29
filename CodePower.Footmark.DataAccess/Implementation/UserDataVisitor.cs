using CodePower.Footmark.DataAccess.DBContext;
using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess
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
            using (var dbContext = new UserDBContext())
            {
                var consumer = dbContext.AuthConsumers
                    .Include("Tokens")
                    .FirstOrDefault(x => x.ConsumerKey == consumerKey && x.ConsumerSecret == consumerSecret);
                return consumer;
            }
        }
        /// <summary>
        /// Fetch Auth AccessToken
        /// </summary>
        /// <param name="accessToken">access token</param>
        /// <returns>AuthToken</returns>
        public AuthTokenDM FetchAuthAccessToken(string accessToken)
        {
            using (var dbContext = new UserDBContext())
            {
                var query = (
                    from authToken in dbContext.AuthTokens.Include("Consumer")
                    where authToken.AccessToken == accessToken
                    select authToken
                );
                return query.FirstOrDefault();
            }
        }
        /// <summary>
        /// Create auth token
        /// </summary>
        /// <param name="token"></param>
        public void CreateAuthToken(AuthTokenDM token)
        {
            using (var dbContext = new UserDBContext())
            {
                dbContext.AuthTokens.Add(token);
                dbContext.SaveChanges();
            }
        }
        /// <summary>
        /// Update AuthToken
        /// </summary>
        /// <param name="token">token</param>
        public void UpdateAuthToken(AuthTokenDM token)
        {
            using (var dbContext = new UserDBContext())
            {
                var entity = dbContext.AuthTokens.FirstOrDefault(x => x.SysNo == token.SysNo);
                entity.AccessToken = token.AccessToken;
                entity.RefreshToken = token.RefreshToken;
                entity.ConfusionCode = token.ConfusionCode;
                entity.ExpirationTime = token.ExpirationTime;
                entity.ExpirationInterval = token.ExpirationInterval;
                entity.UpdateUserSysNo = token.UpdateUserSysNo;
                entity.UpdateUserName = token.UpdateUserName;
                entity.UpdateTime = token.UpdateTime;
                dbContext.SaveChanges();
            }
        }
        /// <summary>
        /// Feach user information by user system no.
        /// </summary>
        /// <param name="sysNo">user sysno</param>
        /// <returns>entity</returns>
        public UserInformationDM FeachUserInformation(int sysNo)
        {
            using (var dbContext = new UserDBContext())
            { 
                var query = (
                    from user in dbContext.UserInformations
                    where user.SysNo == sysNo
                    select user
                );
                return query.FirstOrDefault();
            }
        }
        /// <summary>
        /// Feach user information by user name.
        /// </summary>
        /// <param name="sysName">user name</param>
        /// <returns>entity</returns>
        public UserInformationDM FeachUserInformation(string userName)
        {
            using (var dbContext = new UserDBContext())
            {
                var query = (
                    from user in dbContext.UserInformations
                    where user.Name == userName
                    select user
                );
                return query.FirstOrDefault();
            }
        }
        #endregion Data access option
    }
}
