using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_PAYMENT_REFUND
    {
        public int INDIVIDUAL_PAYMENT_REFUND_ID { get; set; }
        public int CC_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int REGISTRATION_INSTANCE_ID { get; set; }
        public decimal REFUND_AMOUNT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual COMMONCC COMMONCC { get; set; }
        public virtual REGISTRATION_INSTANCE REGISTRATION_INSTANCE { get; set; }
    }
}
