using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REQUIRED_ACTIVITY_ATTRIBUTE
    {
        public int ACTIVITY_ID { get; set; }
        public int ACTIVITY_ATTRIBUTE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> OLD_ACT_ID { get; set; }
        public Nullable<int> OLD_ACT_ATTR_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ACTIVITY_ATTRIBUTE ACTIVITY_ATTRIBUTE { get; set; }
    }
}
