using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FREQ_TAG_COMMENT
    {
        public int FREQ_COMMENT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string TAG_COMMENT { get; set; }
        public string TAG_COMMENT_ABBREVIATION { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
    }
}
