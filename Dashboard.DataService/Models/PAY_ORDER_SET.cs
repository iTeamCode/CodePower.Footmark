using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_ORDER_SET
    {
        public PAY_ORDER_SET()
        {
            this.FORM_INDIVIDUAL_SET = new List<FORM_INDIVIDUAL_SET>();
            this.PAY_ORDER = new List<PAY_ORDER>();
            this.PAY_PAYMENT = new List<PAY_PAYMENT>();
            this.PAY_PRICING_ADJUSTMENT_ORDER_SET = new List<PAY_PRICING_ADJUSTMENT_ORDER_SET>();
            this.PAY_TRANSACTION = new List<PAY_TRANSACTION>();
        }

        public int PAY_ORDER_SET_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public decimal AMOUNT { get; set; }
        public string PP_REQUEST_CODE { get; set; }
        public string PAYMENT_DESCRIPTION { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public decimal UNADJUSTED_AMOUNT { get; set; }
        public virtual ICollection<FORM_INDIVIDUAL_SET> FORM_INDIVIDUAL_SET { get; set; }
        public virtual ICollection<PAY_ORDER> PAY_ORDER { get; set; }
        public virtual ICollection<PAY_PAYMENT> PAY_PAYMENT { get; set; }
        public virtual ICollection<PAY_PRICING_ADJUSTMENT_ORDER_SET> PAY_PRICING_ADJUSTMENT_ORDER_SET { get; set; }
        public virtual ICollection<PAY_TRANSACTION> PAY_TRANSACTION { get; set; }
    }
}
