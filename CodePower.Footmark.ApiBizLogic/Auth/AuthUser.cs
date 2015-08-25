using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    /// <summary>
    /// AuthUser
    /// </summary>
    public class AuthUser
    {
        /// <summary>
        /// Consumer application which call our api.
        /// </summary>
        public ConsumerApp Consumer { get; set; }
        /// <summary>
        /// user roles list.
        /// </summary>
        public Dictionary<int, string> Authorization { get; set; }
        /// <summary>
        /// user information.
        /// </summary>
        public CurrentUserDM User { get; set; }
    }
}
