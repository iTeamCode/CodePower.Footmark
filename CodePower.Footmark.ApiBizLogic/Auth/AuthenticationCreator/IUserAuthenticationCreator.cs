using CodePower.Footmark.Model.ContractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    /// <summary>
    /// interface for user authentication creator
    /// </summary>
    public interface IUserAuthenticationCreator
    {
        /// <summary>
        /// Authentication User (use to sign in logic.)
        /// </summary>
        /// <param name="userName">user name</param>
        /// <param name="password">password</param>
        /// <param name="churchCode">church code</param>
        /// <returns>SignInViewModel</returns>
        SignInCM AuthenticationUser(string userName, string password, string churchCode);
    }
}
