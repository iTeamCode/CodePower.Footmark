using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess
{
    public interface IDataVisitor
    {
        CurrentUserDM CurrentUser { get; set; }
    }
}
