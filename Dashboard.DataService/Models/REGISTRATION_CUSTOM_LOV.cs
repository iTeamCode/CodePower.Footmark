using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_CUSTOM_LOV
    {
        public int LIST_VALUE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> REGISTRATION_CUSTOM_ID { get; set; }
        public string LIST_VALUE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual REGISTRATION_CUSTOM REGISTRATION_CUSTOM { get; set; }
    }
}
