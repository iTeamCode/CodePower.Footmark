using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REFERENCE
    {
        public REFERENCE()
        {
            this.REFERENCE_INSTANCE = new List<REFERENCE_INSTANCE>();
            this.REFERENCE_INTERVIEW = new List<REFERENCE_INTERVIEW>();
        }

        public int REFERENCE_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string ST_PROVINCE { get; set; }
        public string POSTAL_CODE { get; set; }
        public string HOME_PHONE { get; set; }
        public string WORK_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string RELATIONSHIP { get; set; }
        public bool IS_CLOSED { get; set; }
        public int VOLUNTEER_OPPORTUNITY_INSTANCE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string ADDRESS_2 { get; set; }
        public string ADDRESS_3 { get; set; }
        public string COUNTRY { get; set; }
        public virtual ICollection<REFERENCE_INSTANCE> REFERENCE_INSTANCE { get; set; }
        public virtual ICollection<REFERENCE_INTERVIEW> REFERENCE_INTERVIEW { get; set; }
        public virtual VOLUNTEER_OPPORTUNITY_INSTANCE VOLUNTEER_OPPORTUNITY_INSTANCE { get; set; }
    }
}
