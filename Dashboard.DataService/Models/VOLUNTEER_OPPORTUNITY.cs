using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class VOLUNTEER_OPPORTUNITY
    {
        public VOLUNTEER_OPPORTUNITY()
        {
            this.VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM = new List<VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM>();
            this.VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM = new List<VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM>();
            this.VOLUNTEER_OPPORTUNITY_REQUIREMENT = new List<VOLUNTEER_OPPORTUNITY_REQUIREMENT>();
            this.VOLUNTEER_OPPORTUNITY_USER = new List<VOLUNTEER_OPPORTUNITY_USER>();
        }

        public int VOLUNTEER_OPPORTUNITY_ID { get; set; }
        public Nullable<int> CHURCH_ID { get; set; }
        public int VOLUNTEER_APPLICATION_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public int MINISTRY_ID { get; set; }
        public Nullable<int> ACTIVITY_ID { get; set; }
        public Nullable<int> ACTIVITY_DETAIL_ID { get; set; }
        public Nullable<int> ACTIVITY_TIME_ID { get; set; }
        public Nullable<int> ACTIVITY_INSTANCE_ID { get; set; }
        public Nullable<int> INDIVIDUAL_GROUP_ID { get; set; }
        public Nullable<int> STAFFING_SCHEDULE_ID { get; set; }
        public Nullable<int> JOB_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string OPPORTUNITY_DESCRIPTION { get; set; }
        public virtual VOLUNTEER_APPLICATION VOLUNTEER_APPLICATION { get; set; }
        public virtual ICollection<VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM> VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM { get; set; }
        public virtual ICollection<VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM> VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM { get; set; }
        public virtual ICollection<VOLUNTEER_OPPORTUNITY_REQUIREMENT> VOLUNTEER_OPPORTUNITY_REQUIREMENT { get; set; }
        public virtual ICollection<VOLUNTEER_OPPORTUNITY_USER> VOLUNTEER_OPPORTUNITY_USER { get; set; }
    }
}
