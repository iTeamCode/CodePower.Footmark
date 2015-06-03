using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_LINE_ITEM
    {
        public PAY_LINE_ITEM()
        {
            this.PAY_PAYMENT = new List<PAY_PAYMENT>();
            this.PAY_PRICING_ADJUSTMENT_LINE_ITEM = new List<PAY_PRICING_ADJUSTMENT_LINE_ITEM>();
        }

        public int PAY_LINE_ITEM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int PAY_ORDER_ID { get; set; }
        public int PAY_PRICING_ITEM_ID { get; set; }
        public string LINE_ITEM_NAME { get; set; }
        public string LINE_ITEM_DESCRIPTION { get; set; }
        public decimal UNADJUSTED_AMOUNT { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public bool IS_DELETED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual PAY_ORDER PAY_ORDER { get; set; }
        public virtual PAY_PRICING_ITEM PAY_PRICING_ITEM { get; set; }
        public virtual ICollection<PAY_PAYMENT> PAY_PAYMENT { get; set; }
        public virtual ICollection<PAY_PRICING_ADJUSTMENT_LINE_ITEM> PAY_PRICING_ADJUSTMENT_LINE_ITEM { get; set; }
    }
}
