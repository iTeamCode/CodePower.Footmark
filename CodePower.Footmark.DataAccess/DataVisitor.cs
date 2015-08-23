using CodePower.Framework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess
{
    /// <summary>
    /// Manager the Data visitor
    /// </summary>
    public class DataVisitor
    {
        public DataVisitor()
        {
            //Ioc...
            this.ActivityVisitor = IocFactory.CreateObject<IActivityDataVisitor>();
            this.ProjectVisitor = IocFactory.CreateObject<IProjectDataVisitor>();
            this.UserVisitor = IocFactory.CreateObject<IUserDataVisitor>();

            //set current user.
            //this.activityDA.CurrentUser = user;
        }

        #region DataVisitor
        /// <summary>
        /// get or set Data visitor for DB 'fmkActivity'
        /// </summary>
        public IActivityDataVisitor ActivityVisitor { get; set; }
        /// <summary>
        /// get or set Data visitor for DB 'fmkProject'
        /// </summary>
        public IProjectDataVisitor ProjectVisitor { get; set; }
        /// <summary>
        /// get or set Data visitor for DB 'fmkUser'
        /// </summary>
        public IUserDataVisitor UserVisitor { get; set; }
        #endregion
    }
}
