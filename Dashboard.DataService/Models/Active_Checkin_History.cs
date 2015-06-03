using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class Active_Checkin_History
    {
        public int Active_Checkin_History_ID { get; set; }
        public Nullable<int> ACTIVE_CHECKIN_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public System.DateTime Audit_Created_Date { get; set; }
    }
}
