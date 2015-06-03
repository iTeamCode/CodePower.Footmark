using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_PAYMENT_OPTION
    {
        public REGISTRATION_PAYMENT_OPTION()
        {
            this.REGISTRATION_PAYMENT = new List<REGISTRATION_PAYMENT>();
        }

        public int REGISTRATION_PAYMENT_OPTION_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string PAYMENT_OPTION_NAME { get; set; }
        public Nullable<decimal> PAYMENT_AMOUNT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<REGISTRATION_PAYMENT> REGISTRATION_PAYMENT { get; set; }
    }
}
