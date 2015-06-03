using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_INSTANCE
    {
        public REGISTRATION_INSTANCE()
        {
            this.INDIVIDUAL_PAYMENT_REFUND = new List<INDIVIDUAL_PAYMENT_REFUND>();
            this.INDIVIDUAL_REGISTRATION_2 = new List<INDIVIDUAL_REGISTRATION_2>();
            this.REGISTRATION_INSTANCE_PAYMENT = new List<REGISTRATION_INSTANCE_PAYMENT>();
        }

        public int REGISTRATION_INSTANCE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_REGISTRATION_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public string EMAIL { get; set; }
        public string CONFIRMATION_CODE { get; set; }
        public System.DateTime CREATED { get; set; }
        public Nullable<System.DateTime> MODIFIED { get; set; }
        public Nullable<int> COMPANY_ID { get; set; }
        public Nullable<int> ACTIVITY_REGISTRATION_PARENT_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_REGISTRATION ACTIVITY_REGISTRATION { get; set; }
        public virtual ICollection<INDIVIDUAL_PAYMENT_REFUND> INDIVIDUAL_PAYMENT_REFUND { get; set; }
        public virtual ICollection<INDIVIDUAL_REGISTRATION_2> INDIVIDUAL_REGISTRATION_2 { get; set; }
        public virtual ICollection<REGISTRATION_INSTANCE_PAYMENT> REGISTRATION_INSTANCE_PAYMENT { get; set; }
    }
}
