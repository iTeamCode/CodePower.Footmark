using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_GROUP
    {
        public INDIVIDUAL_GROUP()
        {
            this.ACTIVITY_DETAIL = new List<ACTIVITY_DETAIL>();
            this.FORM_ITEM_OPTION = new List<FORM_ITEM_OPTION>();
            this.INDIVIDUAL_INSTANCE = new List<INDIVIDUAL_INSTANCE>();
            this.INDIVIDUAL_PREFS = new List<INDIVIDUAL_PREFS>();
            this.RG_ACTIVITY_REGISTRATION = new List<RG_ACTIVITY_REGISTRATION>();
        }

        public int INDIVIDUAL_GROUP_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string INDIVIDUAL_GROUP_NAME { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string TAG_CODE { get; set; }
        public Nullable<int> old_ind_grp_id { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<ACTIVITY_DETAIL> ACTIVITY_DETAIL { get; set; }
        public virtual ICollection<FORM_ITEM_OPTION> FORM_ITEM_OPTION { get; set; }
        public virtual ICollection<INDIVIDUAL_INSTANCE> INDIVIDUAL_INSTANCE { get; set; }
        public virtual ICollection<INDIVIDUAL_PREFS> INDIVIDUAL_PREFS { get; set; }
        public virtual ICollection<RG_ACTIVITY_REGISTRATION> RG_ACTIVITY_REGISTRATION { get; set; }
    }
}
