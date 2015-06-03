using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class syncobj_0x4144364238373337
    {
        public int PAY_TRANSACTION_ID { get; set; }
        public Nullable<int> CHURCH_ID { get; set; }
        public int PAY_TRANSACTION_TYPE_ID { get; set; }
        public int PAY_TRANSACTION_STATUS_TYPE_ID { get; set; }
        public string PP_REQUEST_CODE { get; set; }
        public Nullable<int> PP_REQUEST_ID { get; set; }
        public decimal AMOUNT { get; set; }
        public System.DateTime TRANSACTION_DATE { get; set; }
        public string PAYMENT_DESCRIPTION { get; set; }
        public string MEMO { get; set; }
        public int PAY_ORDER_SET_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
    }
}
