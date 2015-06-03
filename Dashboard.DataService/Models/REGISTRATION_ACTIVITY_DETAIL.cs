using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_ACTIVITY_DETAIL
    {
        public int REGISTRATION_ITEM_ID { get; set; }
        public int ACTIVITY_DETAIL_ID { get; set; }
        public int ACTIVITY_REGISTRATION_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> MAX_REGISTRATIONS { get; set; }
        public bool IS_DEFAULT { get; set; }
        public bool ENABLED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual ACTIVITY_REGISTRATION ACTIVITY_REGISTRATION { get; set; }
        public virtual REGISTRATION_ITEM REGISTRATION_ITEM { get; set; }
    }
}
