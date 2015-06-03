using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_INSTANCE_PAYMENT
    {
        public REGISTRATION_INSTANCE_PAYMENT()
        {
            this.INDIVIDUAL_PAYMENT = new List<INDIVIDUAL_PAYMENT>();
        }

        public int REGISTRATION_INSTANCE_PAYMENT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int REGISTRATION_INSTANCE_ID { get; set; }
        public System.DateTime PAYMENT_DATE_TIME { get; set; }
        public int PAYMENT_TYPE_ID { get; set; }
        public Nullable<int> CC_ID { get; set; }
        public decimal AMOUNT { get; set; }
        public Nullable<int> PROMOTION_CODE_ID { get; set; }
        public bool PROCESSED { get; set; }
        public string REFERENCE { get; set; }
        public Nullable<int> CHECK_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual COMMONCC COMMONCC { get; set; }
        public virtual ICollection<INDIVIDUAL_PAYMENT> INDIVIDUAL_PAYMENT { get; set; }
        public virtual PROMOTION_CODE PROMOTION_CODE { get; set; }
        public virtual REGISTRATION_INSTANCE REGISTRATION_INSTANCE { get; set; }
        public virtual REGISTRATION_PAYMENT_TYPE REGISTRATION_PAYMENT_TYPE { get; set; }
    }
}
