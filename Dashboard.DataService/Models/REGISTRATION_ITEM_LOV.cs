using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_ITEM_LOV
    {
        public REGISTRATION_ITEM_LOV()
        {
            this.INDIVIDUAL_REGISTRATION_ITEM_LOV = new List<INDIVIDUAL_REGISTRATION_ITEM_LOV>();
        }

        public int REGISTRATION_ITEM_LOV_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int REGISTRATION_ITEM_ID { get; set; }
        public string REGISTRATION_ITEM_NAME { get; set; }
        public Nullable<decimal> PRICE_PER_ITEM { get; set; }
        public Nullable<int> MAX_QUANTITY { get; set; }
        public Nullable<int> MAX_REGISTRATIONS { get; set; }
        public bool IS_DEFAULT { get; set; }
        public Nullable<bool> ENABLED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<INDIVIDUAL_REGISTRATION_ITEM_LOV> INDIVIDUAL_REGISTRATION_ITEM_LOV { get; set; }
        public virtual REGISTRATION_ITEM REGISTRATION_ITEM { get; set; }
    }
}
