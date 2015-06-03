using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class RG_ACTIVITY_REGISTRATION
    {
        public RG_ACTIVITY_REGISTRATION()
        {
            this.RG_ACTIVITY_REGISTRATION_SCHEDULE = new List<RG_ACTIVITY_REGISTRATION_SCHEDULE>();
        }

        public int FORM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public Nullable<int> ACTIVITY_DETAIL_ID { get; set; }
        public Nullable<int> INDIVIDUAL_GROUP_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual FORM FORM { get; set; }
        public virtual INDIVIDUAL_GROUP INDIVIDUAL_GROUP { get; set; }
        public virtual ICollection<RG_ACTIVITY_REGISTRATION_SCHEDULE> RG_ACTIVITY_REGISTRATION_SCHEDULE { get; set; }
    }
}
