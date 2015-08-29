using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    /// <summary>
    /// interface for user infomation creator
    /// </summary>
    public interface IUserInfomationCreator
    {
        /// <summary>
        /// get user information.
        /// </summary>
        /// <param name="context">context object</param>
        /// <returns>current user</returns>
        CurrentUserDM GetUserInformation(AuthUserContext context);
    }
}
