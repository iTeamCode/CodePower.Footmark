using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_ORDER
    {
        public PAY_ORDER()
        {
            this.FORM_INDIVIDUAL = new List<FORM_INDIVIDUAL>();
            this.PAY_LINE_ITEM = new List<PAY_LINE_ITEM>();
            this.PAY_PAYMENT = new List<PAY_PAYMENT>();
            this.PAY_PRICING_ADJUSTMENT_ORDER = new List<PAY_PRICING_ADJUSTMENT_ORDER>();
        }

        public int PAY_ORDER_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int PAY_ORDER_SET_ID { get; set; }
        public decimal UNADJUSTED_AMOUNT { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public int PAY_ORDER_STATUS_TYPE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<FORM_INDIVIDUAL> FORM_INDIVIDUAL { get; set; }
        public virtual ICollection<PAY_LINE_ITEM> PAY_LINE_ITEM { get; set; }
        public virtual PAY_ORDER_SET PAY_ORDER_SET { get; set; }
        public virtual PAY_ORDER_STATUS_TYPE PAY_ORDER_STATUS_TYPE { get; set; }
        public virtual ICollection<PAY_PAYMENT> PAY_PAYMENT { get; set; }
        public virtual ICollection<PAY_PRICING_ADJUSTMENT_ORDER> PAY_PRICING_ADJUSTMENT_ORDER { get; set; }
    }
}
