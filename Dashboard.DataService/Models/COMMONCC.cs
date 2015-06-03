using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class COMMONCC
    {
        public COMMONCC()
        {
            this.INDIVIDUAL_PAYMENT_REFUND = new List<INDIVIDUAL_PAYMENT_REFUND>();
            this.REGISTRATION_INSTANCE_PAYMENT = new List<REGISTRATION_INSTANCE_PAYMENT>();
        }

        public int CC_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public Nullable<int> CC_TYPE { get; set; }
        public string CC_NO { get; set; }
        public Nullable<System.DateTime> CC_DATE { get; set; }
        public string CC_NAME { get; set; }
        public string CC_ADD1 { get; set; }
        public string CC_ADD2 { get; set; }
        public string CC_CITY { get; set; }
        public string CC_STATE { get; set; }
        public string CC_POSTAL_CODE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string CC_ADD3 { get; set; }
        public string CC_COUNTRY { get; set; }
        public virtual ICollection<INDIVIDUAL_PAYMENT_REFUND> INDIVIDUAL_PAYMENT_REFUND { get; set; }
        public virtual ICollection<REGISTRATION_INSTANCE_PAYMENT> REGISTRATION_INSTANCE_PAYMENT { get; set; }
    }
}
