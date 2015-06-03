using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_PREFS
    {
        public INDIVIDUAL_PREFS()
        {
            this.FORM_ITEM_OPTION_INDIVIDUAL = new List<FORM_ITEM_OPTION_INDIVIDUAL>();
            this.RG_INDIVIDUAL_REGISTRATION = new List<RG_INDIVIDUAL_REGISTRATION>();
        }

        public int INDIVIDUAL_PREF_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public Nullable<int> ACTIVITY_DETAIL_ID { get; set; }
        public Nullable<int> ACTIVITY_TIME_ID { get; set; }
        public Nullable<int> ACTIVITY_INSTANCE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> INDIVIDUAL_GROUP_ID { get; set; }
        public string DEFAULT_TAG_COMMENT { get; set; }
        public Nullable<int> END_ACTIVITY_INSTANCE_ID { get; set; }
        public Nullable<int> INDIVIDUAL_REGISTRATION_ID { get; set; }
        public Nullable<System.DateTime> LAST_MOVE_DATE { get; set; }
        public Nullable<int> LAST_ACTIVITY_DETAIL { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> MassActionID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual ICollection<FORM_ITEM_OPTION_INDIVIDUAL> FORM_ITEM_OPTION_INDIVIDUAL { get; set; }
        public virtual INDIVIDUAL_GROUP INDIVIDUAL_GROUP { get; set; }
        public virtual INDIVIDUAL_REGISTRATION_2 INDIVIDUAL_REGISTRATION_2 { get; set; }
        public virtual ICollection<RG_INDIVIDUAL_REGISTRATION> RG_INDIVIDUAL_REGISTRATION { get; set; }
    }
}
