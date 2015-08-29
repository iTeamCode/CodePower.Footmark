using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.Model.DomainModel
{
    public class UserInformationDM : BaseDomainModel
    {
        public int SysNo { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int TypeID { get; set; }
        public bool IsEnabled { get; set; }
    }
}
