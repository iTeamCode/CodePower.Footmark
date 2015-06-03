using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class STAFFING_PREF
    {
        public int STAFFING_PREF_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public int INDIVIDUAL_TYPE_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public Nullable<int> ACTIVITY_DETAIL_ID { get; set; }
        public Nullable<int> ACTIVITY_TIME_ID { get; set; }
        public Nullable<int> ACTIVITY_INSTANCE_ID { get; set; }
        public Nullable<int> INDIVIDUAL_GROUP_ID { get; set; }
        public int STAFFING_SCHEDULE_ID { get; set; }
        public Nullable<int> JOB_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<int> ACTIVITY_GROUP_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<bool> Add_Individual { get; set; }
        public Nullable<int> MassActionID { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual ACTIVITY_TIME ACTIVITY_TIME { get; set; }
        public virtual INDIVIDUAL_TYPE INDIVIDUAL_TYPE { get; set; }
        public virtual JOB JOB { get; set; }
        public virtual STAFFING_SCHEDULE STAFFING_SCHEDULE { get; set; }
    }
}
