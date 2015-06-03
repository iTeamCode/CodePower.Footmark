using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_ATTRIBUTE
    {
        public ACTIVITY_ATTRIBUTE()
        {
            this.ACTIVITY_INSTANCE_ATTRIBUTE = new List<ACTIVITY_INSTANCE_ATTRIBUTE>();
            this.REQUIRED_ACTIVITY_ATTRIBUTE = new List<REQUIRED_ACTIVITY_ATTRIBUTE>();
        }

        public int ACTIVITY_ATTRIBUTE_ID { get; set; }
        public string CHURCH_ID { get; set; }
        public string ACTIVITY_ATTRIBUTE_NAME { get; set; }
        public bool IS_PERIPHERAL { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> OLD_ACT_ATTR_ID { get; set; }
        public virtual ICollection<ACTIVITY_INSTANCE_ATTRIBUTE> ACTIVITY_INSTANCE_ATTRIBUTE { get; set; }
        public virtual ICollection<REQUIRED_ACTIVITY_ATTRIBUTE> REQUIRED_ACTIVITY_ATTRIBUTE { get; set; }
    }
}
