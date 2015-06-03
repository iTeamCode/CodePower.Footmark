using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class VOLUNTEER_APPLICATION
    {
        public VOLUNTEER_APPLICATION()
        {
            this.VOLUNTEER_OPPORTUNITY_INSTANCE = new List<VOLUNTEER_OPPORTUNITY_INSTANCE>();
            this.VOLUNTEER_OPPORTUNITY = new List<VOLUNTEER_OPPORTUNITY>();
        }

        public int VOLUNTEER_APPLICATION_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string CONFIRMATION_MESSAGE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<VOLUNTEER_OPPORTUNITY_INSTANCE> VOLUNTEER_OPPORTUNITY_INSTANCE { get; set; }
        public virtual ICollection<VOLUNTEER_OPPORTUNITY> VOLUNTEER_OPPORTUNITY { get; set; }
    }
}
