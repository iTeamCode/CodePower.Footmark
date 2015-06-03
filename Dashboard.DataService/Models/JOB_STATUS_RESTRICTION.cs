using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class JOB_STATUS_RESTRICTION
    {
        public int JOB_ID { get; set; }
        public int STATUS_GROUP_ID { get; set; }
        public int STATUS_ID { get; set; }
        public int STATUS_SELECTLIST { get; set; }
        public int CHURCH_ID { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public int JOB_STATUS_RESTRICTION_ID { get; set; }
        public virtual JOB JOB { get; set; }
    }
}
