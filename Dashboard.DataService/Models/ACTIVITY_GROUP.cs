using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_GROUP
    {
        public ACTIVITY_GROUP()
        {
            this.ACTIVITY_DETAIL = new List<ACTIVITY_DETAIL>();
            this.ACTIVITY_GROUP1 = new List<ACTIVITY_GROUP>();
        }

        public int ACTIVITY_GROUP_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string ACTIVITY_GROUP_NAME { get; set; }
        public Nullable<int> ACTIVITY_SUPER_GROUP_ID { get; set; }
        public int ACTIVITY_GROUP_SORT { get; set; }
        public int CHECKIN_BALANCE_TYPE { get; set; }
        public Nullable<int> OLD_ACT_GRP_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> OLD_ACT_SUPER_GRP_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<ACTIVITY_DETAIL> ACTIVITY_DETAIL { get; set; }
        public virtual ICollection<ACTIVITY_GROUP> ACTIVITY_GROUP1 { get; set; }
        public virtual ACTIVITY_GROUP ACTIVITY_GROUP2 { get; set; }
    }
}
