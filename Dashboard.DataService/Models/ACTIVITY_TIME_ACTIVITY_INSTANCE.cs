using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_TIME_ACTIVITY_INSTANCE
    {
        public int ACTIVITY_TIME_ID { get; set; }
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> OLD_ACT_TIME_ID { get; set; }
        public Nullable<int> OLD_ACT_INS_ID { get; set; }
        public virtual ACTIVITY_TIME ACTIVITY_TIME { get; set; }
    }
}
