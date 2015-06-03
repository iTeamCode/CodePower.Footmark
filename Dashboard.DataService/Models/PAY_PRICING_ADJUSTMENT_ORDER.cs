using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_PRICING_ADJUSTMENT_ORDER
    {
        public int PAY_PRICING_ADJUSTMENT_ID { get; set; }
        public int PAY_ORDER_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual PAY_ORDER PAY_ORDER { get; set; }
        public virtual PAY_PRICING_ADJUSTMENT PAY_PRICING_ADJUSTMENT { get; set; }
    }
}
