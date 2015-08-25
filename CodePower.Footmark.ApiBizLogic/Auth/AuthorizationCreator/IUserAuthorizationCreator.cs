using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    /// <summary>
    /// interface for user authorization creator
    /// </summary>
    public interface IUserAuthorizationCreator
    {
        /// <summary>
        /// get user authorization.
        /// </summary>
        /// <param name="context">context</param>
        /// <returns>user rights</returns>
        Dictionary<int, string> GetUserAuthorization(AuthUserContext context);
    }
}
