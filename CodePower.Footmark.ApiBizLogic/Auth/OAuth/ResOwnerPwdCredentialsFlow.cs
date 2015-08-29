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

            var token = consumer.Tokens.FirstOrDefault(x => x.UserSysNo == user.UserSysNo);
            if (token != null && token.ExpirationTime < DateTime.Now)
            {   //Refresh token.
                token.AccessToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "AccessToken");
                token.RefreshToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "RefreshToken");
                token.ExpirationTime = DateTime.Now.AddDays(Convert.ToDouble(token.ExpirationInterval));
                token.UpdateUserSysNo = -1;
                token.UpdateUserName = "System User";
                token.UpdateTime = DateTime.Now;
                dataVisitor.UpdateAuthToken(token);
            }
            else
            {   //Create Token.
                token = new AuthTokenDM()
                {
                    AuthConsumerSysNo = consumer.SysNo,
                    AccessToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "AccessToken"),
                    RefreshToken = AuthManager.GeneratedToken(consumer.ConsumerKey, consumer.ConsumerSecret, "RefreshToken"),
                    ConfusionCode = string.Empty,
                    ExpirationTime = DateTime.Now.AddDays(1),
                    ExpirationInterval = 1,
                    UserSysNo = user.UserSysNo,
                    TypeId = 0,
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
                ExpirationDate = token.ExpirationTime.ToString(),
                RefreshToken = token.RefreshToken,
                User = user
            };

        }


    }
}
