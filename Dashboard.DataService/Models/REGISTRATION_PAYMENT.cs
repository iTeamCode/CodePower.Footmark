using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_PAYMENT
    {
        public int REGISTRATION_PAYMENT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int REGISTRATION_PAYMENT_OPTION_ID { get; set; }
        public int INDIVIDUAL_REGISTRATION_ID { get; set; }
        public Nullable<System.DateTime> PAYMENT_DATE { get; set; }
        public int PAYMENT_TYPE_ID { get; set; }
        public Nullable<decimal> PAYMENT_AMOUNT { get; set; }
        public Nullable<int> CC_ID { get; set; }
        public bool PROCESSED { get; set; }
        public Nullable<int> CHECK_NO { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual REGISTRATION_PAYMENT_OPTION REGISTRATION_PAYMENT_OPTION { get; set; }
        public virtual REGISTRATION_PAYMENT_TYPE REGISTRATION_PAYMENT_TYPE { get; set; }
    }
}
