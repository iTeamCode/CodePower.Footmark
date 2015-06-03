using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_PROPERTY_LOV
    {
        public ACTIVITY_PROPERTY_LOV()
        {
            this.ACTIVITY_PROPERTY_ACTIVITY_DETAIL = new List<ACTIVITY_PROPERTY_ACTIVITY_DETAIL>();
        }

        public int ACTIVITY_PROPERTY_LOV_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_PROPERTY_ID { get; set; }
        public string ACTIVITY_PROPERTY_LOV_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_PROPERTY ACTIVITY_PROPERTY { get; set; }
        public virtual ICollection<ACTIVITY_PROPERTY_ACTIVITY_DETAIL> ACTIVITY_PROPERTY_ACTIVITY_DETAIL { get; set; }
    }
}
