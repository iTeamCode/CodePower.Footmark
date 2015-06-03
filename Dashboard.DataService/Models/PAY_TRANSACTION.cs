using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_TRANSACTION
    {
        public PAY_TRANSACTION()
        {
            this.PAY_PAYMENT = new List<PAY_PAYMENT>();
        }

        public int PAY_TRANSACTION_ID { get; set; }
        public Nullable<int> CHURCH_ID { get; set; }
        public int PAY_TRANSACTION_TYPE_ID { get; set; }
        public int PAY_TRANSACTION_STATUS_TYPE_ID { get; set; }
        public string PP_REQUEST_CODE { get; set; }
        public Nullable<int> PP_REQUEST_ID { get; set; }
        public decimal AMOUNT { get; set; }
        public System.DateTime TRANSACTION_DATE { get; set; }
        public string PAYMENT_DESCRIPTION { get; set; }
        public string MEMO { get; set; }
        public int PAY_ORDER_SET_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual PAY_ORDER_SET PAY_ORDER_SET { get; set; }
        public virtual ICollection<PAY_PAYMENT> PAY_PAYMENT { get; set; }
        public virtual PAY_TRANSACTION_STATUS_TYPE PAY_TRANSACTION_STATUS_TYPE { get; set; }
        public virtual PAY_TRANSACTION_TYPE PAY_TRANSACTION_TYPE { get; set; }
    }
}
