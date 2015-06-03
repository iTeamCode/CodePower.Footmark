using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class RG_ACTIVITY_REGISTRATION_SCHEDULE
    {
        public int ACTIVITY_REGISTRATION_SCHEDULE_ID { get; set; }
        public int FORM_ID { get; set; }
        public Nullable<int> ACTIVITY_TIME_ID { get; set; }
        public Nullable<int> ACTIVITY_INSTANCE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ACTIVITY_INSTANCE ACTIVITY_INSTANCE { get; set; }
        public virtual ACTIVITY_TIME ACTIVITY_TIME { get; set; }
        public virtual RG_ACTIVITY_REGISTRATION RG_ACTIVITY_REGISTRATION { get; set; }
    }
}
