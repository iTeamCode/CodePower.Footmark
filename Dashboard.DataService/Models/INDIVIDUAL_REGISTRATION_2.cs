using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_REGISTRATION_2
    {
        public INDIVIDUAL_REGISTRATION_2()
        {
            this.INDIVIDUAL_PAYMENT = new List<INDIVIDUAL_PAYMENT>();
            this.INDIVIDUAL_PREFS = new List<INDIVIDUAL_PREFS>();
            this.INDIVIDUAL_REGISTRATION_ITEM = new List<INDIVIDUAL_REGISTRATION_ITEM>();
            this.INDIVIDUAL_REGISTRATION_ITEM_LOV = new List<INDIVIDUAL_REGISTRATION_ITEM_LOV>();
        }

        public int INDIVIDUAL_REGISTRATION_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> REGISTRATION_INSTANCE_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public Nullable<int> ACTIVITY_TIME_ID { get; set; }
        public Nullable<int> ACTIVITY_INSTANCE_ID { get; set; }
        public Nullable<int> ACTIVITY_DETAIL_ID { get; set; }
        public System.DateTime CREATED { get; set; }
        public Nullable<System.DateTime> MODIFIED { get; set; }
        public Nullable<bool> IS_GLOBAL { get; set; }
        public Nullable<int> CC_ID { get; set; }
        public Nullable<int> ACTIVITY_REGISTRATION_ID { get; set; }
        public Nullable<int> REGISTRATION_STATUS_ID { get; set; }
        public Nullable<int> CHECK_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual ICollection<INDIVIDUAL_PAYMENT> INDIVIDUAL_PAYMENT { get; set; }
        public virtual ICollection<INDIVIDUAL_PREFS> INDIVIDUAL_PREFS { get; set; }
        public virtual REGISTRATION_INSTANCE REGISTRATION_INSTANCE { get; set; }
        public virtual REGISTRATION_STATUS REGISTRATION_STATUS { get; set; }
        public virtual ICollection<INDIVIDUAL_REGISTRATION_ITEM> INDIVIDUAL_REGISTRATION_ITEM { get; set; }
        public virtual ICollection<INDIVIDUAL_REGISTRATION_ITEM_LOV> INDIVIDUAL_REGISTRATION_ITEM_LOV { get; set; }
    }
}
