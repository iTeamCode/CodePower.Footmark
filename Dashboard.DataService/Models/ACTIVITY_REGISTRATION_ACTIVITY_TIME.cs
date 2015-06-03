using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_REGISTRATION_ACTIVITY_TIME
    {
        public int ACTIVITY_REGISTRATION_ID { get; set; }
        public int ACTIVITY_TIME_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_REGISTRATION ACTIVITY_REGISTRATION { get; set; }
        public virtual ACTIVITY_TIME ACTIVITY_TIME { get; set; }
    }
}
