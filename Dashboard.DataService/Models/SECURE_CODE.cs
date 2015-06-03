using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class SECURE_CODE
    {
        public SECURE_CODE()
        {
            this.CHURCH_SECURE_CODE = new List<CHURCH_SECURE_CODE>();
        }

        public int SECURE_CODE_ID { get; set; }
        public string SECURE_CODE1 { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<CHURCH_SECURE_CODE> CHURCH_SECURE_CODE { get; set; }
    }
}
