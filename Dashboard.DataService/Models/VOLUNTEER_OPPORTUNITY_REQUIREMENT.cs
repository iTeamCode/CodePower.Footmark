using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class VOLUNTEER_OPPORTUNITY_REQUIREMENT
    {
        public int VOLUNTEER_OPPORTUNITY_ID { get; set; }
        public int REQUIREMENT_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual VOLUNTEER_OPPORTUNITY VOLUNTEER_OPPORTUNITY { get; set; }
    }
}
