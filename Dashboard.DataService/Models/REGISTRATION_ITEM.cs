using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_ITEM
    {
        public REGISTRATION_ITEM()
        {
            this.INDIVIDUAL_REGISTRATION_ITEM = new List<INDIVIDUAL_REGISTRATION_ITEM>();
            this.INDIVIDUAL_REGISTRATION_ITEM_LOV = new List<INDIVIDUAL_REGISTRATION_ITEM_LOV>();
            this.REGISTRATION_ACTIVITY_DETAIL = new List<REGISTRATION_ACTIVITY_DETAIL>();
            this.REGISTRATION_ITEM_LOV = new List<REGISTRATION_ITEM_LOV>();
        }

        public int REGISTRATION_ITEM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int REGISTRATION_GROUP_ID { get; set; }
        public string REGISTRATION_ITEM_NAME { get; set; }
        public string REGISTRATION_ITEM_DESC { get; set; }
        public int SORT { get; set; }
        public bool IS_LOV { get; set; }
        public int MAX_LOV_ALLOWED { get; set; }
        public bool IS_ACTIVITY_DETAIL { get; set; }
        public bool ENABLED { get; set; }
        public int REGISTRATION_ITEM_TYPE_ID { get; set; }
        public bool IS_REQUIRED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<INDIVIDUAL_REGISTRATION_ITEM> INDIVIDUAL_REGISTRATION_ITEM { get; set; }
        public virtual ICollection<INDIVIDUAL_REGISTRATION_ITEM_LOV> INDIVIDUAL_REGISTRATION_ITEM_LOV { get; set; }
        public virtual ICollection<REGISTRATION_ACTIVITY_DETAIL> REGISTRATION_ACTIVITY_DETAIL { get; set; }
        public virtual REGISTRATION_GROUP REGISTRATION_GROUP { get; set; }
        public virtual ICollection<REGISTRATION_ITEM_LOV> REGISTRATION_ITEM_LOV { get; set; }
        public virtual REGISTRATION_ITEM_TYPE REGISTRATION_ITEM_TYPE { get; set; }
    }
}
