using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_PAYMENT_REQUIREMENT
    {
        public int PAY_PAYMENT_REQUIREMENT_ID { get; set; }
        public int PAY_PAYMENT_REQUIREMENT_TYPE_ID { get; set; }
        public int PAY_ITEM_ID { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<int> PERCENTAGE { get; set; }
        public Nullable<System.DateTime> REQUIRED_DATE { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual PAY_ITEM PAY_ITEM { get; set; }
        public virtual PAY_PAYMENT_REQUIREMENT_TYPE PAY_PAYMENT_REQUIREMENT_TYPE { get; set; }
    }
}
