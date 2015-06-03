using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class MINISTRY
    {
        public MINISTRY()
        {
            this.ACTIVITY_MINISTRY = new List<ACTIVITY_MINISTRY>();
            this.AUTOMATIC_ATTENDANCE_RULE = new List<AUTOMATIC_ATTENDANCE_RULE>();
        }

        public int MINISTRY_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> GLOBAL_MINISTRY_ID { get; set; }
        public string MINISTRY_NAME { get; set; }
        public Nullable<int> MERCHANT_ACCOUNT_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<int> OLD_MIN_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<ACTIVITY_MINISTRY> ACTIVITY_MINISTRY { get; set; }
        public virtual ICollection<AUTOMATIC_ATTENDANCE_RULE> AUTOMATIC_ATTENDANCE_RULE { get; set; }
        public virtual GLOBAL_MINISTRY GLOBAL_MINISTRY { get; set; }
    }
}
