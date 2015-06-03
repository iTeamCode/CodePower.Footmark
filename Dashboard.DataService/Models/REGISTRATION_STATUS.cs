using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_STATUS
    {
        public REGISTRATION_STATUS()
        {
            this.INDIVIDUAL_REGISTRATION_2 = new List<INDIVIDUAL_REGISTRATION_2>();
        }

        public int REGISTRATION_STATUS_ID { get; set; }
        public string REGISTRATION_STATUS_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<INDIVIDUAL_REGISTRATION_2> INDIVIDUAL_REGISTRATION_2 { get; set; }
    }
}
