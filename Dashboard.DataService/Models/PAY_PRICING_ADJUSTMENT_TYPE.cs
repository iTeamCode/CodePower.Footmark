using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_PRICING_ADJUSTMENT_TYPE
    {
        public PAY_PRICING_ADJUSTMENT_TYPE()
        {
            this.PAY_PRICING_ADJUSTMENT = new List<PAY_PRICING_ADJUSTMENT>();
        }

        public int PAY_PRICING_ADJUSTMENT_TYPE_ID { get; set; }
        public string PRICING_ADJUSTMENT_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<PAY_PRICING_ADJUSTMENT> PAY_PRICING_ADJUSTMENT { get; set; }
    }
}
