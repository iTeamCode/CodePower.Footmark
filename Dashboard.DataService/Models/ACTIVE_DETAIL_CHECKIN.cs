using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVE_DETAIL_CHECKIN
    {
        public int ACTIVITY_DETAIL_ID { get; set; }
        public int ACTIVE_CHECKIN_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public bool IS_OPEN { get; set; }
        public Nullable<int> CAPACITY { get; set; }
        public int VOLUNTEER_COUNT { get; set; }
        public int HOLDOVER_COUNT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVE_CHECKIN ACTIVE_CHECKIN { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
    }
}
