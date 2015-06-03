using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class TAG_ITEM
    {
        public TAG_ITEM()
        {
            this.TAG_TEMPLATE_ITEM = new List<TAG_TEMPLATE_ITEM>();
        }

        public int TAG_ITEM_ID { get; set; }
        public string TAG_ITEM_DESC { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<TAG_TEMPLATE_ITEM> TAG_TEMPLATE_ITEM { get; set; }
    }
}
