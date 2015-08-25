using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.ApiBizLogic.Auth
{
    public class AuthUserContext
    {
        /// <summary>
        /// get or set 'user id'
        /// </summary>
        public int AuthUserId { get; set; }
        /// <summary>
        /// get or set 'church id'
        /// </summary>
        public int AuthChurchId { get; set; }
    }
}
