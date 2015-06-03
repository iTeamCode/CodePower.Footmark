using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_PAYMENT_TYPE
    {
        public REGISTRATION_PAYMENT_TYPE()
        {
            this.REGISTRATION_INSTANCE_PAYMENT = new List<REGISTRATION_INSTANCE_PAYMENT>();
            this.REGISTRATION_PAYMENT = new List<REGISTRATION_PAYMENT>();
        }

        public int PAYMENT_TYPE_ID { get; set; }
        public string PAYMENT_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<REGISTRATION_INSTANCE_PAYMENT> REGISTRATION_INSTANCE_PAYMENT { get; set; }
        public virtual ICollection<REGISTRATION_PAYMENT> REGISTRATION_PAYMENT { get; set; }
    }
}
