using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_ITEM_TYPE
    {
        public PAY_ITEM_TYPE()
        {
            this.PAY_ITEM = new List<PAY_ITEM>();
        }

        public int PAY_ITEM_TYPE_ID { get; set; }
        public string PAY_ITEM_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<PAY_ITEM> PAY_ITEM { get; set; }
    }
}
