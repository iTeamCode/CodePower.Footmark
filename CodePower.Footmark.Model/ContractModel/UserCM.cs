using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.Model.ContractModel
{
    /// <summary>
    /// user contract model.
    /// </summary>
    public class UserCM
    {
        /// <summary>
        /// get or set 'SysNo'
        /// </summary>
        public int SysNo { get; set; }
        /// <summary>
        /// get or set 'Name'
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// get or set 'EMail'
        /// </summary>
        public string EMail { get; set; }
        /// <summary>
        /// get or set 'Password'
        /// </summary>
        public string Password { get; set; }
    }
}
