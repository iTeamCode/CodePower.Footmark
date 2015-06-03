using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_TRANSACTION_TYPE
    {
        public PAY_TRANSACTION_TYPE()
        {
            this.PAY_TRANSACTION = new List<PAY_TRANSACTION>();
        }

        public int PAY_TRANSACTION_TYPE_ID { get; set; }
        public string PAY_TRANSACTION_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<PAY_TRANSACTION> PAY_TRANSACTION { get; set; }
    }
}
