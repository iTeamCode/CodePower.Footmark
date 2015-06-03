using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_REGISTRATION_ITEM_LOV
    {
        public int INDIVIDUAL_REGISTRATION_ID { get; set; }
        public int REGISTRATION_ITEM_ID { get; set; }
        public int REGISTRATION_ITEM_LOV { get; set; }
        public int CHURCH_ID { get; set; }
        public int QUANTITY { get; set; }
        public Nullable<decimal> TOTAL_AMOUNT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual INDIVIDUAL_REGISTRATION_2 INDIVIDUAL_REGISTRATION_2 { get; set; }
        public virtual REGISTRATION_ITEM REGISTRATION_ITEM { get; set; }
        public virtual REGISTRATION_ITEM_LOV REGISTRATION_ITEM_LOV1 { get; set; }
    }
}
