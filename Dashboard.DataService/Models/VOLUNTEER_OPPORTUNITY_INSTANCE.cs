using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class VOLUNTEER_OPPORTUNITY_INSTANCE
    {
        public VOLUNTEER_OPPORTUNITY_INSTANCE()
        {
            this.REFERENCEs = new List<REFERENCE>();
            this.VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM = new List<VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM>();
        }

        public int VOLUNTEER_OPPORTUNITY_INSTANCE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public int VOLUNTEER_APPLICATION_ID { get; set; }
        public System.DateTime CREATED_DATETIME { get; set; }
        public string COMMENT { get; set; }
        public bool REJECTED { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<REFERENCE> REFERENCEs { get; set; }
        public virtual VOLUNTEER_APPLICATION VOLUNTEER_APPLICATION { get; set; }
        public virtual ICollection<VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM> VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM { get; set; }
    }
}
