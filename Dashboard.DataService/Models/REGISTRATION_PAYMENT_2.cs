using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_PAYMENT_2
    {
        public REGISTRATION_PAYMENT_2()
        {
            this.INDIVIDUAL_PAYMENT = new List<INDIVIDUAL_PAYMENT>();
        }

        public int REGISTRATION_PAYMENT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_REGISTRATION_ID { get; set; }
        public System.DateTime START_DATE { get; set; }
        public System.DateTime END_DATE { get; set; }
        public decimal PAYMENT_AMOUNT { get; set; }
        public bool DOWNPAYMENT_ALLOWED { get; set; }
        public Nullable<decimal> DOWNPAYMENT_AMOUNT { get; set; }
        public Nullable<System.DateTime> FULL_PAYMENT_DATE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_REGISTRATION ACTIVITY_REGISTRATION { get; set; }
        public virtual ICollection<INDIVIDUAL_PAYMENT> INDIVIDUAL_PAYMENT { get; set; }
    }
}
