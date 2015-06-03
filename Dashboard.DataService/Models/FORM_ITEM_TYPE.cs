using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_ITEM_TYPE
    {
        public FORM_ITEM_TYPE()
        {
            this.FORM_ITEM = new List<FORM_ITEM>();
        }

        public int FORM_ITEM_TYPE_ID { get; set; }
        public string FORM_ITEM_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<FORM_ITEM> FORM_ITEM { get; set; }
    }
}
