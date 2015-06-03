using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_SERIES
    {
        public ACTIVITY_SERIES()
        {
            this.ACTIVITY_INSTANCE = new List<ACTIVITY_INSTANCE>();
        }

        public int ACTIVITY_SERIES_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string ACTIVITY_SERIES_NAME { get; set; }
        public int ACTIVITY_ID { get; set; }
        public Nullable<System.DateTime> SERIES_START_DATE { get; set; }
        public Nullable<System.DateTime> SERIES_END_DATE { get; set; }
        public Nullable<int> SERIES_TOPIC_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<ACTIVITY_INSTANCE> ACTIVITY_INSTANCE { get; set; }
        public virtual SERIES_TOPIC SERIES_TOPIC { get; set; }
    }
}
