using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class syncobj_0x4438393646343643
    {
        public int PAY_ORDER_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int PAY_ORDER_SET_ID { get; set; }
        public decimal UNADJUSTED_AMOUNT { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public int PAY_ORDER_STATUS_TYPE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
    }
}
