using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVE_CHECKIN
    {
        public ACTIVE_CHECKIN()
        {
            this.ACTIVE_DETAIL_CHECKIN = new List<ACTIVE_DETAIL_CHECKIN>();
        }

        public int ACTIVE_CHECKIN_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_INSTANCE ACTIVITY_INSTANCE { get; set; }
        public virtual ICollection<ACTIVE_DETAIL_CHECKIN> ACTIVE_DETAIL_CHECKIN { get; set; }
    }
}
