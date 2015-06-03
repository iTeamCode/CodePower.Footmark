using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class GLOBAL_ACTIVITY
    {
        public GLOBAL_ACTIVITY()
        {
            this.GLOBAL_ACTIVITY_TIME = new List<GLOBAL_ACTIVITY_TIME>();
        }

        public int GLOBAL_ACTIVITY_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string GLOBAL_ACTIVITY_NAME { get; set; }
        public Nullable<int> CHECKIN_CODE { get; set; }
        public Nullable<int> old_glbl_act_id { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> THEME_ID { get; set; }
        public virtual ICollection<GLOBAL_ACTIVITY_TIME> GLOBAL_ACTIVITY_TIME { get; set; }
    }
}
