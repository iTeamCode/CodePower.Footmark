using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_PRICING_ADJUSTMENT
    {
        public PAY_PRICING_ADJUSTMENT()
        {
            this.PAY_PRICING_ADJUSTMENT_LINE_ITEM = new List<PAY_PRICING_ADJUSTMENT_LINE_ITEM>();
            this.PAY_PRICING_ADJUSTMENT_ORDER = new List<PAY_PRICING_ADJUSTMENT_ORDER>();
            this.PAY_PRICING_ADJUSTMENT_ORDER_SET = new List<PAY_PRICING_ADJUSTMENT_ORDER_SET>();
        }

        public int PAY_PRICING_ADJUSTMENT_ID { get; set; }
        public int PAY_PRICING_ADJUSTMENT_TYPE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<int> PERCENTAGE { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public string MEMO { get; set; }
        public virtual ICollection<PAY_PRICING_ADJUSTMENT_LINE_ITEM> PAY_PRICING_ADJUSTMENT_LINE_ITEM { get; set; }
        public virtual ICollection<PAY_PRICING_ADJUSTMENT_ORDER> PAY_PRICING_ADJUSTMENT_ORDER { get; set; }
        public virtual ICollection<PAY_PRICING_ADJUSTMENT_ORDER_SET> PAY_PRICING_ADJUSTMENT_ORDER_SET { get; set; }
        public virtual PAY_PRICING_ADJUSTMENT_TYPE PAY_PRICING_ADJUSTMENT_TYPE { get; set; }
        public virtual PAY_PROMOTION_CODE PAY_PROMOTION_CODE { get; set; }
    }
}
