using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_PROMOTION_CODE
    {
        public PAY_PROMOTION_CODE()
        {
            this.FORM_PROMOTION_CODE = new List<FORM_PROMOTION_CODE>();
        }

        public int PAY_PRICING_ADJUSTMENT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string PROMOTION_CODE_NAME { get; set; }
        public string PROMOTION_CODE_CODE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<int> TOTAL_USES { get; set; }
        public Nullable<int> USES_LEFT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<FORM_PROMOTION_CODE> FORM_PROMOTION_CODE { get; set; }
        public virtual PAY_PRICING_ADJUSTMENT PAY_PRICING_ADJUSTMENT { get; set; }
    }
}
