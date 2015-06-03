using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_TYPE
    {
        public ACTIVITY_TYPE()
        {
            this.ACTIVITY_TYPE_ACTIVITY = new List<ACTIVITY_TYPE_ACTIVITY>();
        }

        public int ACTIVITY_TYPE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string ACTIVITY_TYPE_NAME { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<ACTIVITY_TYPE_ACTIVITY> ACTIVITY_TYPE_ACTIVITY { get; set; }
    }
}
