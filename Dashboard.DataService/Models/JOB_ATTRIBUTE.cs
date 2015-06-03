using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class JOB_ATTRIBUTE
    {
        public JOB_ATTRIBUTE()
        {
            this.JOB_JOB_ATTRIBUTE = new List<JOB_JOB_ATTRIBUTE>();
        }

        public int JOB_ATTRIBUTE_ID { get; set; }
        public int JOB_ATTRIBUTE_GROUP_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string JOB_ATTRIBUTE_NAME { get; set; }
        public bool IS_DELETED { get; set; }
        public int SORT { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual JOB_ATTRIBUTE_GROUP JOB_ATTRIBUTE_GROUP { get; set; }
        public virtual ICollection<JOB_JOB_ATTRIBUTE> JOB_JOB_ATTRIBUTE { get; set; }
    }
}
