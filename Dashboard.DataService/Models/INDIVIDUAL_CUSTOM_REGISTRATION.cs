using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_CUSTOM_REGISTRATION
    {
        public int INDIVIDUAL_REGISTRATION_ID { get; set; }
        public int REGISTRATION_CUSTOM_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string CUSTOM_VALUE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual REGISTRATION_CUSTOM REGISTRATION_CUSTOM { get; set; }
    }
}
