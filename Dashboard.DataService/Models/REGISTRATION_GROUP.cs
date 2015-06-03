using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_GROUP
    {
        public REGISTRATION_GROUP()
        {
            this.REGISTRATION_ITEM = new List<REGISTRATION_ITEM>();
        }

        public int REGISTRATION_GROUP_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_REGISTRATION_ID { get; set; }
        public string REGISTRATION_GROUP_NAME { get; set; }
        public int SORT { get; set; }
        public bool IS_GLOBAL_GROUP { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_REGISTRATION ACTIVITY_REGISTRATION { get; set; }
        public virtual ICollection<REGISTRATION_ITEM> REGISTRATION_ITEM { get; set; }
    }
}
