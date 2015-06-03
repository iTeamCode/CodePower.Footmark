using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM
    {
        public int VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM1 { get; set; }
        public int CHURCH_ID { get; set; }
        public int VOLUNTEER_OPPORTUNITY_INSTANCE_ID { get; set; }
        public int VOLUNTEER_OPPORTUNITY_ITEM_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_INTERESTED { get; set; }
        public bool HAS_MINSITRY_PROCESSED { get; set; }
        public int VOLUNTEER_OPPORTUNITY_STATUS_ID { get; set; }
        public Nullable<int> VOLUNTEER_OPPORTUNITY_REJECTION_NOTE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual VOLUNTEER_OPPORTUNITY VOLUNTEER_OPPORTUNITY { get; set; }
        public virtual VOLUNTEER_OPPORTUNITY_INSTANCE VOLUNTEER_OPPORTUNITY_INSTANCE { get; set; }
        public virtual VOLUNTEER_OPPORTUNITY_REJECTION_NOTE VOLUNTEER_OPPORTUNITY_REJECTION_NOTE { get; set; }
        public virtual VOLUNTEER_OPPORTUNITY_STATUS VOLUNTEER_OPPORTUNITY_STATUS { get; set; }
    }
}
