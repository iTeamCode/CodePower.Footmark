using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class syncobj_0x3434443233344334
    {
        public int PAY_PAYMENT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int PAY_TRANSACTION_ID { get; set; }
        public Nullable<int> PAY_LINE_ITEM_ID { get; set; }
        public Nullable<int> PAY_ORDER_ID { get; set; }
        public Nullable<int> PAY_ORDER_SET_ID { get; set; }
        public decimal AMOUNT { get; set; }
        public System.DateTime PAYMENT_DATE { get; set; }
        public string MEMO { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
    }
}
