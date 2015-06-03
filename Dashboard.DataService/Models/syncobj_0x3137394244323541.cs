using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class syncobj_0x3137394244323541
    {
        public int PROMOTION_CODE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_REGISTRATION_ID { get; set; }
        public string PROMOTION_CODE_NAME { get; set; }
        public string PROMOTION_CODE { get; set; }
        public Nullable<decimal> DISCOUNT_AMOUNT { get; set; }
        public Nullable<int> DISCOUNT_PERCENTAGE { get; set; }
        public bool AUTO_GENERATED { get; set; }
        public bool IS_INDIVIDUAL { get; set; }
        public bool MULTIPLE_USE { get; set; }
        public bool HOUSEHOLD_ONLY { get; set; }
        public bool STAFF_ONLY { get; set; }
        public System.DateTime START_DATE { get; set; }
        public System.DateTime END_DATE { get; set; }
        public bool ENABLED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
    }
}
