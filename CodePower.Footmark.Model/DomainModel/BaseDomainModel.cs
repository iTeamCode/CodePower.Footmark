using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.Model.DomainModel
{
    /// <summary>
    /// Base entity for DomainModel
    /// </summary>
    public class BaseDomainModel
    {
        /// <summary>
        /// get or set 'CreateTime'
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// get or set 'CreateUserSysNo'
        /// </summary>
        public int CreateUserSysNo { get; set; }
        /// <summary>
        /// get or set 'CreateUserName'
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// get or set 'UpdateTime'
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// get or set 'UpdateUserSysNo'
        /// </summary>
        public int UpdateUserSysNo { get; set; }
        /// <summary>
        /// get or set 'UpdateUserName'
        /// </summary>
        public string UpdateUserName { get; set; }
    }
}
