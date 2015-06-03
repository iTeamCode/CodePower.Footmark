using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class STAFFING_SCHEDULE
    {
        public STAFFING_SCHEDULE()
        {
            this.STAFFING_PREF = new List<STAFFING_PREF>();
            this.STAFFING_RECURRENCE = new List<STAFFING_RECURRENCE>();
        }

        public int STAFFING_SCHEDULE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string STAFFING_SCHEDULE_NAME { get; set; }
        public Nullable<int> old_staff_sched_id { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<STAFFING_PREF> STAFFING_PREF { get; set; }
        public virtual ICollection<STAFFING_RECURRENCE> STAFFING_RECURRENCE { get; set; }
    }
}
