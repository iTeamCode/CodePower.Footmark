using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_PAYMENT
    {
        public int INDIVIDUAL_PAYMENT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int INDIVIDUAL_REGISTRATION_ID { get; set; }
        public int REGISTRATION_INSTANCE_PAYMENT_ID { get; set; }
        public Nullable<int> REGISTRATION_PAYMENT_ID { get; set; }
        public decimal PAYMENT_AMOUNT { get; set; }
        public decimal ITEMS_AMOUNT { get; set; }
        public Nullable<int> PROMOTION_CODE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual INDIVIDUAL_REGISTRATION_2 INDIVIDUAL_REGISTRATION_2 { get; set; }
        public virtual PROMOTION_CODE PROMOTION_CODE { get; set; }
        public virtual REGISTRATION_INSTANCE_PAYMENT REGISTRATION_INSTANCE_PAYMENT { get; set; }
        public virtual REGISTRATION_PAYMENT_2 REGISTRATION_PAYMENT_2 { get; set; }
    }
}