using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_REGISTRATION_JOIN
    {
        public int ACTIVITY_REGISTRATION_PARENT_ID { get; set; }
        public int ACTIVITY_REGISTRATION_CHILD_ID { get; set; }
        public Nullable<bool> TIME_RESTRICTED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_REGISTRATION ACTIVITY_REGISTRATION { get; set; }
        public virtual ACTIVITY_REGISTRATION ACTIVITY_REGISTRATION1 { get; set; }
    }
}
