using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_PROMOTION_CODE
    {
        public int FORM_ID { get; set; }
        public int PAY_PRICING_ADJUSTMENT_ID { get; set; }
        public Nullable<int> CHURCH_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual FORM FORM { get; set; }
        public virtual PAY_PROMOTION_CODE PAY_PROMOTION_CODE { get; set; }
    }
}
