using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class SERIES_TOPIC
    {
        public SERIES_TOPIC()
        {
            this.ACTIVITY_SERIES = new List<ACTIVITY_SERIES>();
        }

        public int SERIES_TOPIC_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string SERIES_TOPIC_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<ACTIVITY_SERIES> ACTIVITY_SERIES { get; set; }
    }
}
