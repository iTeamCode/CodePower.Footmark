using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_TAG
    {
        public int TAG_TEMPLATE_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public bool IS_RECEIPT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual TAG_TEMPLATE TAG_TEMPLATE { get; set; }
    }
}
