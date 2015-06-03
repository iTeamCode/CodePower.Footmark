using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class syncobj_0x4131363332373536
    {
        public int PAY_LINE_ITEM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int PAY_ORDER_ID { get; set; }
        public int PAY_PRICING_ITEM_ID { get; set; }
        public string LINE_ITEM_NAME { get; set; }
        public string LINE_ITEM_DESCRIPTION { get; set; }
        public decimal UNADJUSTED_AMOUNT { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public bool IS_DELETED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
    }
}
