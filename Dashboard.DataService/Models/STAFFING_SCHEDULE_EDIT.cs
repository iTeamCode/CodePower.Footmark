using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class STAFFING_SCHEDULE_EDIT
    {
        public int INDIVIDUAL_ID { get; set; }
        public int INDIVIDUAL_TYPE_ID { get; set; }
        public int ACTIVITY_DETAIL_ID { get; set; }
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> JOB_ID { get; set; }
        public int EDIT_TYPE { get; set; }
        public string NOTE { get; set; }
        public Nullable<int> INDIVIDUAL_GROUP_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual ACTIVITY_INSTANCE ACTIVITY_INSTANCE { get; set; }
        public virtual INDIVIDUAL_TYPE INDIVIDUAL_TYPE { get; set; }
    }
}
