using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class TAG_DATA_FIELD
    {
        public TAG_DATA_FIELD()
        {
            this.TAG_TEMPLATE_ITEM = new List<TAG_TEMPLATE_ITEM>();
        }

        public int TAG_DATA_FIELD_ID { get; set; }
        public string DATABASE_NAME { get; set; }
        public string TABLE_NAME { get; set; }
        public string TABLE_COLUMN { get; set; }
        public string FORMAT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<TAG_TEMPLATE_ITEM> TAG_TEMPLATE_ITEM { get; set; }
    }
}
