using CodePower.Footmark.Model.ContractModel;
using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    public class RefreshTokenFlow : IOAuth
    {

        private AuthCM _model;
        public RefreshTokenFlow(AuthCM model)
        {
            _model = model;
        }

        public object GenerateAccessToken()
        {
            string consumerKey = _model.ConsumerKey;
            string consumerSecret = _model.ConsumerSecret;
            string refreshToken = _model.RefreshToken;

            #region check input data.
            if (string.IsNullOrWhiteSpace(consumerKey))
            {
                throw new ArgumentException("Your 'consumerKey' is empty.");
            }

            if (string.IsNullOrWhiteSpace(consumerSecret))
            {
                throw new ArgumentException("Your 'consumerSecret' is empty.");
            }

            if (string.IsNullOrWhiteSpace(refreshToken))
            {
                throw new ArgumentException("Your 'refreshToken' is empty.");
            }
            #endregion check input data

            #region check the 'refreshToken'
            //[TO DO]:var consumer = this.dashboardDA.FeachAuthenticateConsumer(consumerKey, consumerSecret);
            var consumer = new AuthConsumerDM();
            if (consumer == null)
            {
                //[TO DO]://throw new BusinessException("Can not find consumer information with 'consumerKey' & 'consumerSecret'!");
            }
            if (consumer.IsEnabled == false)
            {
                //[TO DO]://throw new BusinessException("Your consumer is disabled!");
            }

            var token = consumer.Tokens.FirstOrDefault(x => x.RefreshToken == refreshToken);
            if (token == null)
            {
                //[TO DO]:throw new BusinessException("Your refresh token is disabled!");
            }
            #endregion check the 'refreshToken'

            //Save and return new token.
            token.AccessToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "AccessToken");
            token.RefreshToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "RefreshToken");
            token.ExpirationDate = DateTime.Now.AddDays(Convert.ToDouble(token.ExpirationInterval));
            //token.LastUpdatedByUserId = 0;
            //token.LastUpdatedByUserName = "System User";
            //token.LastUpdatedDate = DateTime.Now;

            //[TO DO]:this.dashboardDA.UpdateAuthenticateToken(token);
            return new
            {
                TokenType = "bearer",
                AccessToken = token.AccessToken,
                ExpirationDate = token.ExpirationDate.ToString(),
                RefreshToken = token.RefreshToken
            };
        }
    }
}
