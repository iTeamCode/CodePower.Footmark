using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class HOUSEHOLD_ATTENDANCE
    {
        public int ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public int PROCESSED_IND { get; set; }
    }
}
