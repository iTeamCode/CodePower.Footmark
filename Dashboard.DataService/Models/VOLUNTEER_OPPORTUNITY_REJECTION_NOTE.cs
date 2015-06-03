using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class VOLUNTEER_OPPORTUNITY_REJECTION_NOTE
    {
        public VOLUNTEER_OPPORTUNITY_REJECTION_NOTE()
        {
            this.VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM = new List<VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM>();
        }

        public int VOLUNTEER_OPPORTUNITY_REJECTION_NOTE_ID { get; set; }
        public string REJECTION_NOTE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM> VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM { get; set; }
    }
}
