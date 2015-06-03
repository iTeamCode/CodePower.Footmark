using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_PRICING_ADJUSTMENT_LINE_ITEM
    {
        public int PAY_PRICING_ADJUSTMENT_ID { get; set; }
        public int PAY_LINE_ITEM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual PAY_LINE_ITEM PAY_LINE_ITEM { get; set; }
        public virtual PAY_PRICING_ADJUSTMENT PAY_PRICING_ADJUSTMENT { get; set; }
    }
}
