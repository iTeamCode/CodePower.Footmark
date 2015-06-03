using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_PROPERTY
    {
        public ACTIVITY_PROPERTY()
        {
            this.ACTIVITY_PROPERTY_LOV = new List<ACTIVITY_PROPERTY_LOV>();
        }

        public int ACTIVITY_PROPERTY_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string ACTIVITY_PROPERTY_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public bool IS_FILTER_CHOICE { get; set; }
        public bool SHOW_RESULTS { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<ACTIVITY_PROPERTY_LOV> ACTIVITY_PROPERTY_LOV { get; set; }
    }
}
