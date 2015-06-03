using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_TYPE
    {
        public INDIVIDUAL_TYPE()
        {
            this.INDIVIDUAL_INSTANCE = new List<INDIVIDUAL_INSTANCE>();
            this.STAFFING_PREF = new List<STAFFING_PREF>();
            this.STAFFING_SCHEDULE_EDIT = new List<STAFFING_SCHEDULE_EDIT>();
        }

        public int INDIVIDUAL_TYPE_ID { get; set; }
        public string INDIVIDUAL_TYPE_NAME { get; set; }
        public bool HAS_TIMESHEET { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public int INDIVIDUAL_TYPE_GROUP_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public virtual ICollection<INDIVIDUAL_INSTANCE> INDIVIDUAL_INSTANCE { get; set; }
        public virtual ICollection<STAFFING_PREF> STAFFING_PREF { get; set; }
        public virtual ICollection<STAFFING_SCHEDULE_EDIT> STAFFING_SCHEDULE_EDIT { get; set; }
    }
}
