using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_DETAIL_INSTANCE
    {
        public ACTIVITY_DETAIL_INSTANCE()
        {
            this.ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE = new List<ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE>();
        }

        public int ACTIVITY_DETAIL_INSTANCE_ID { get; set; }
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public int ACTIVITY_DETAIL_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> ATTENDANCE { get; set; }
        public Nullable<System.DateTime> ACTUAL_MEETING_DATE { get; set; }
        public string MEETING_NOTE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual ACTIVITY_INSTANCE ACTIVITY_INSTANCE { get; set; }
        public virtual ICollection<ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE> ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE { get; set; }
    }
}
