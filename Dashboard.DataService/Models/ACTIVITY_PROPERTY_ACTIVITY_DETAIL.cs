using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_PROPERTY_ACTIVITY_DETAIL
    {
        public int ACTIVITY_PROPERTY_LOV_ID { get; set; }
        public int ACTIVITY_DETAIL_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual ACTIVITY_PROPERTY_LOV ACTIVITY_PROPERTY_LOV { get; set; }
    }
}
