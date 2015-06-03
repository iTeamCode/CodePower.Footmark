using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_PAYMENT_REQUIREMENT_TYPE
    {
        public PAY_PAYMENT_REQUIREMENT_TYPE()
        {
            this.PAY_PAYMENT_REQUIREMENT = new List<PAY_PAYMENT_REQUIREMENT>();
        }

        public int PAY_PAYMENT_REQUIREMENT_TYPE_ID { get; set; }
        public string PAY_PAYMENT_REQUIREMENT_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<PAY_PAYMENT_REQUIREMENT> PAY_PAYMENT_REQUIREMENT { get; set; }
    }
}
