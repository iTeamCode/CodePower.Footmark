using CodePower.Footmark.DataAccess;
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
        /// <summary>
        /// Generate access token
        /// </summary>
        /// <returns>entity</returns>
        public object GenerateAccessToken()
        {
            //#01[Auth consumer].Get consumer information. 
            var dataVisitor = DataVisitor.Create<IUserDataVisitor>();
            var consumer = dataVisitor.FeachAuthConsumer(_model.ConsumerKey, _model.ConsumerSecret);
            if (consumer == null)
            {
                //throw new BusinessException("Can not get consumer by 'consumerKey' & 'consumerSecret'!");
            }

            //#02.Authentication User.
            var factory = AuthUserFactory.CreateAuthUserFactory((ConsumerApp)consumer.ConsumerAppID);
            var user = factory.AuthenticationUser(_model.UserName, _model.Password, _model.ChurchCode);

            var token = consumer.Tokens.FirstOrDefault(x => x.UserID == user.UserId);
            if (token != null && token.ExpirationDate < DateTime.Now)
            {   //Refresh token.
                token.AccessToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "AccessToken");
                token.RefreshToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "RefreshToken");
                token.ExpirationDate = DateTime.Now.AddDays(Convert.ToDouble(token.ExpirationInterval));
                token.UpdateUserSysNo = -1;
                token.UpdateUserName = "System User";
                token.UpdateTime = DateTime.Now;
                dataVisitor.UpdateAuthToken(token);
            }
            else
            {   //Create Token.
                token = new AuthTokenDM()
                {
                    AuthenticateConsumerID = consumer.AuthConsumerID,
                    AccessToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "AccessToken"),
                    RefreshToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "RefreshToken"),
                    ConfusionCode = string.Empty,
                    ExpirationDate = DateTime.Now.AddDays(1),
                    ExpirationInterval = 1,
                    UserID = user.UserId,
                    Type = 0,
                    CreateUserSysNo = -1,
                    CreateUserName = "System User",
                    CreateTime = DateTime.Now,
                    UpdateUserSysNo = -1,
                    UpdateUserName = "System User",
                    UpdateTime = DateTime.Now
                };
                dataVisitor.CreateAuthToken(token);
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
