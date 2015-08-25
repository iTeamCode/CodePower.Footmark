using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    /// <summary>
    /// No Authorization Creator
    /// </summary>
    public class NoAuthorizationCreator : IUserAuthorizationCreator
    {
        /// <summary>
        /// get user authorization.
        /// </summary>
        /// <param name="context">context</param>
        /// <returns>user rights</returns>
        public Dictionary<int, string> GetUserAuthorization(AuthUserContext context)
        {
            return new Dictionary<int, string>();
        }
    }
}
