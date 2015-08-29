using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess
{
    class ActivityDataVisitor : IActivityDataVisitor
    {
        public CurrentUserDM CurrentUser { get; set; }
    }
}
