using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_ORDER_STATUS_TYPE
    {
        public PAY_ORDER_STATUS_TYPE()
        {
            this.PAY_ORDER = new List<PAY_ORDER>();
        }

        public int PAY_ORDER_STATUS_TYPE_ID { get; set; }
        public string ORDER_STATUS_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<PAY_ORDER> PAY_ORDER { get; set; }
    }
}
