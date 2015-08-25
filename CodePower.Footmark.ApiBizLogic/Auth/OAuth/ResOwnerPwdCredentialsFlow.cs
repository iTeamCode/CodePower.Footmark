using CodePower.Footmark.Model.ContractModel;
using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    public class ResOwnerPwdCredentialsFlow : IOAuth
    {
        private AuthCM _model;
        public ResOwnerPwdCredentialsFlow(AuthCM model)
        {
            _model = model;
        }

        public object GenerateAccessToken()
        {
            //#01[Auth consumer].Get consumer information. 
            //[TO DO]:var consumer = this.dashboardDA.FeachAuthenticateConsumer(_model.ConsumerKey, _model.ConsumerSecret);
            var consumer = new AuthConsumerDM();
            if (consumer == null)
            {
                //throw new BusinessException("Can not get consumer by 'consumerKey' & 'consumerSecret'!");
            }

            //#02.Authentication User.
            var factory = AuthUserFactory.CreateAuthUserFactory((ConsumerApp)consumer.ConsumerAppID);
            var user = factory.AuthenticationUser(_model.UserName, _model.Password, _model.ChurchCode);

            var token = consumer.Tokens.FirstOrDefault(x => x.UserID == user.UserId);
            if (token != null)
            {
                if (token.ExpirationDate < DateTime.Now)
                {
                    //Refresh token.
                    token.AccessToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "AccessToken");
                    token.RefreshToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "RefreshToken");
                    token.ExpirationDate = DateTime.Now.AddDays(Convert.ToDouble(token.ExpirationInterval));
                    //token.LastUpdatedByUserId = 0;
                    //token.LastUpdatedByUserName = "System User";
                    //token.LastUpdatedDate = DateTime.Now;
                    //[TO DO]:this.dashboardDA.UpdateAuthenticateToken(token);
                }
            }
            else
            {
                //Create Token.
                token = new AuthTokenDM()
                {
                    AuthenticateConsumerID = consumer.AuthConsumerID,
                    AccessToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "AccessToken"),
                    RefreshToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "RefreshToken"),
                    ConfusionCode = string.Empty,
                    ExpirationDate = DateTime.Now.AddDays(1),
                    ExpirationInterval = 1,
                    UserID = user.UserId,
                    Type = 0//,
                    //CreatedByUserId = 0,
                    //CreatedByUserName = "System User",
                    //CreatedDate = DateTime.Now,
                    //LastUpdatedByUserId = 0,
                    //LastUpdatedByUserName = "System User",
                    //LastUpdatedDate = DateTime.Now
                };
                //[TO DO]:this.dashboardDA.CreateAuthenticateToken(token);
            }

            return new
            {
                TokenType = "bearer",
                AccessToken = token.AccessToken,
                ExpirationDate = token.ExpirationDate.ToString(),
                RefreshToken = token.RefreshToken,
                User = user
            };

        }


    }
}
