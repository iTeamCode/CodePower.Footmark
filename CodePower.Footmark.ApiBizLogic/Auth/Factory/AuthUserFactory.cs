using CodePower.Footmark.Model.ContractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    /// <summary>
    /// For abstract authentication & authorization user factory. 
    /// </summary>
    public abstract class AuthUserFactory
    {
        public AuthUserFactory(ConsumerApp consumer)
        {
            //this._userId = userId;
            this._consumer = consumer;

            this._userInfoCreator = BuildUserInfomationCreator();
            this._authorizationCreator = BuildUserAuthorizationCreator();
            this._authenticationCreator = BuildUserAuthenticationCreator();
        }

        #region ConsumerApp & Creator Object
        /// <summary>
        /// consumer information
        /// </summary>
        protected ConsumerApp _consumer { get; set; }
        /// <summary>
        /// user information creator.
        /// </summary>
        protected IUserInfomationCreator _userInfoCreator { get; set; }
        /// <summary>
        /// user authorization creator.
        /// </summary>
        protected IUserAuthorizationCreator _authorizationCreator { get; set; }
        /// <summary>
        /// user authentication creator.
        /// </summary>
        protected IUserAuthenticationCreator _authenticationCreator { get; set; }
        #endregion

        #region Action to client.
        /// <summary>
        /// Create authuser information.
        /// </summary>
        /// <param name="userId">user id</param>
        /// <returns>auth user</returns>
        public AuthUser CreateAuthUser(int userId)
        {
            var authUser = new AuthUser();
            var context = new AuthUserContext() { AuthUserId = userId };

            authUser.Consumer = this._consumer;
            authUser.User = _userInfoCreator.GetUserInfomation(context);
            context.AuthChurchId = authUser.User.ChurchId;  //set ChurchId here.
            authUser.Authorization = _authorizationCreator.GetUserAuthorization(context);

            return authUser;
        }
        /// <summary>
        /// Authentication user
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="password">password</param>
        /// <param name="churchCode">church code</param>
        /// <returns>sign user model</returns>
        public SignInCM AuthenticationUser(string userName, string password, string churchCode)
        {
            return _authenticationCreator.AuthenticationUser(userName, password, churchCode);
        }
        #endregion

        #region Abstract method for different application.
        /// <summary>
        /// create user infomation creator.
        /// </summary>
        /// <returns>creator</returns>
        protected abstract IUserInfomationCreator BuildUserInfomationCreator();
        /// <summary>
        /// create user authorization creator.
        /// </summary>
        /// <returns>creator</returns>
        protected abstract IUserAuthorizationCreator BuildUserAuthorizationCreator();
        /// <summary>
        /// create user authentication creator.
        /// </summary>
        /// <returns>creator</returns>
        protected abstract IUserAuthenticationCreator BuildUserAuthenticationCreator();
        #endregion

        #region static create factory.
        /// <summary>
        /// Create AuthUserFactory by ConsumerApp.
        /// </summary>
        /// <param name="consumerApp">ConsumerApp</param>
        /// <returns>AuthUserFactory</returns>
        public static AuthUserFactory CreateAuthUserFactory(ConsumerApp consumerApp)
        {
            switch (consumerApp)
            {
                case ConsumerApp.Footmark:
                    return new FootmarkAuthUserFactory(consumerApp);
                case ConsumerApp.ManagerReport:
                    return new ManagerReportAuthUserFactory(consumerApp);
                default:
                    return null;
            }
        }
        #endregion
    }
}
