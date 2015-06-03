using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_ITEM_TYPE
    {
        public REGISTRATION_ITEM_TYPE()
        {
            this.REGISTRATION_ITEM = new List<REGISTRATION_ITEM>();
        }

        public int REGISTRATION_ITEM_TYPE_ID { get; set; }
        public string REGISTRATION_ITEM_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<REGISTRATION_ITEM> REGISTRATION_ITEM { get; set; }
    }
}
