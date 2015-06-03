using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REGISTRATION_CUSTOM
    {
        public REGISTRATION_CUSTOM()
        {
            this.INDIVIDUAL_CUSTOM_REGISTRATION = new List<INDIVIDUAL_CUSTOM_REGISTRATION>();
            this.REGISTRATION_CUSTOM_LOV = new List<REGISTRATION_CUSTOM_LOV>();
        }

        public int REGISTRATION_CUSTOM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public int FIELD_NO { get; set; }
        public string CUSTOM_FIELD_NAME { get; set; }
        public bool USE_LOV { get; set; }
        public Nullable<int> FIELD_SIZE { get; set; }
        public Nullable<byte> SORT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<INDIVIDUAL_CUSTOM_REGISTRATION> INDIVIDUAL_CUSTOM_REGISTRATION { get; set; }
        public virtual ICollection<REGISTRATION_CUSTOM_LOV> REGISTRATION_CUSTOM_LOV { get; set; }
    }
}
