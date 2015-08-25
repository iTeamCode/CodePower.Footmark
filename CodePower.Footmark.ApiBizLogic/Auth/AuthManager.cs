using CodePower.Footmark.Model.ContractModel;
using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    public class AuthManager
    {
        /// <summary>
        /// CreateAuthFactory
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userFactory"></param>
        /// <returns></returns>
        public bool CreateAuthUserFactory(string token, out AuthUserFactory userFactory, out int userId)
        {
            bool authPass = false;
            userFactory = null;
            userId = 0;
            //[TO DO]:AuthTokenDM authToken = this.dashboardDA.FetchAuthorizationAccessToken(token);
            AuthTokenDM authToken = new AuthTokenDM();

            if (authToken == null || authToken.AccessToken != token || authToken.ExpirationDate <= DateTime.Now) return authPass;
            if (authToken.Consumer == null || !authToken.Consumer.IsEnabled) return authPass;

            var consumerApp = (ConsumerApp)authToken.Consumer.ConsumerAppID;
            userFactory = AuthUserFactory.CreateAuthUserFactory(consumerApp);//authToken.UserID
            userId = authToken.UserID;
            if (userFactory != null)
            {
                authPass = true;
            }
            return authPass;
        }

        /// <summary>
        /// generated token(MD5)
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="secret">secret</param>
        /// <param name="confusionCode">confusion code</param>
        /// <returns></returns>
        public static string GeneratedToken(string key, string secret, string confusionCode)
        {
            string unencryptedStr = string.Format("{0}:{1}:{2}:{3}", DateTime.Now.Ticks, key, secret, confusionCode);
            var md5 = new MD5CryptoServiceProvider();
            var output = md5.ComputeHash(Encoding.Default.GetBytes(unencryptedStr.Trim()));
            var encryptedStr = BitConverter.ToString(output).Replace("-", "") + Guid.NewGuid();
            return encryptedStr;
        }

        public IOAuth CreateAuthProcess(AuthCM model)
        {
            IOAuth flow = null;
            switch (model.GrantType)
            {
                //"password" : resource owner password credentials
                case GrantType.RESOURCE_OWNER_PASSWORD_CREDENTIALS:
                    flow = new ResOwnerPwdCredentialsFlow(model);
                    break;
                ////"client_credentials"
                //case GrantType.CLIENT_CREDENTIALS:
                //    flow = new ClientCredentialsFlow(model);
                //    break;
                //"refresh_token"
                case GrantType.REFRESH_TOKEN:
                    flow = new RefreshTokenFlow(model);
                    break;
            }
            return flow;
        }
    }
}
