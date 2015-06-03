using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class TAG_TEMPLATE
    {
        public TAG_TEMPLATE()
        {
            this.ACTIVITY_TAG = new List<ACTIVITY_TAG>();
            this.TAG_TEMPLATE_ITEM = new List<TAG_TEMPLATE_ITEM>();
        }

        public int TAG_TEMPLATE_ID { get; set; }
        public string TAG_TEMPLATE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<ACTIVITY_TAG> ACTIVITY_TAG { get; set; }
        public virtual ICollection<TAG_TEMPLATE_ITEM> TAG_TEMPLATE_ITEM { get; set; }
    }
}
