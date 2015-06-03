using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REFERENCE_INSTANCE
    {
        public REFERENCE_INSTANCE()
        {
            this.REFERENCE_INTERVIEW = new List<REFERENCE_INTERVIEW>();
        }

        public int REFERENCE_INSTANCE_ID { get; set; }
        public int REFERENCE_ID { get; set; }
        public int USER_ID { get; set; }
        public System.DateTime CREATED_DATETIME { get; set; }
        public bool IS_COMPLETE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual REFERENCE REFERENCE { get; set; }
        public virtual ICollection<REFERENCE_INTERVIEW> REFERENCE_INTERVIEW { get; set; }
    }
}