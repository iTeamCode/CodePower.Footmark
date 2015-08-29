using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.Model.DomainModel
{
    /// <summary>
    /// current user
    /// </summary>
    public class CurrentUserDM : BaseDomainModel
    {
        /// <summary>
        /// get or set 'user sysno'
        /// </summary>
        public int SysNo { get; set; }
        /// <summary>
        /// get or set 'church Id'
        /// </summary>
        public int ChurchId { get; set; }
        /// <summary>
        /// get or set 'user name'
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// get or set 'church code'
        /// </summary>
        public string ChurchCode { get; set; }
    }
}
