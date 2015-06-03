using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_INSTANCE
    {
        public ACTIVITY_INSTANCE()
        {
            this.ACTIVE_CHECKIN = new List<ACTIVE_CHECKIN>();
            this.ACTIVITY_DETAIL_INSTANCE = new List<ACTIVITY_DETAIL_INSTANCE>();
            this.ACTIVITY_INSTANCE_ATTRIBUTE = new List<ACTIVITY_INSTANCE_ATTRIBUTE>();
            this.ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE = new List<ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE>();
            this.INDIVIDUAL_INSTANCE = new List<INDIVIDUAL_INSTANCE>();
            this.RG_INDIVIDUAL_REGISTRATION = new List<RG_INDIVIDUAL_REGISTRATION>();
            this.RG_ACTIVITY_REGISTRATION_SCHEDULE = new List<RG_ACTIVITY_REGISTRATION_SCHEDULE>();
            this.STAFFING_SCHEDULE_EDIT = new List<STAFFING_SCHEDULE_EDIT>();
        }

        public int ACTIVITY_INSTANCE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public System.DateTime START_DATE_TIME { get; set; }
        public Nullable<System.DateTime> START_CHECKIN { get; set; }
        public Nullable<System.DateTime> END_CHECKIN { get; set; }
        public Nullable<int> ACTIVITY_SERIES_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> OLD_ACT_INS_ID { get; set; }
        public virtual ICollection<ACTIVE_CHECKIN> ACTIVE_CHECKIN { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<ACTIVITY_DETAIL_INSTANCE> ACTIVITY_DETAIL_INSTANCE { get; set; }
        public virtual ACTIVITY_SERIES ACTIVITY_SERIES { get; set; }
        public virtual ICollection<ACTIVITY_INSTANCE_ATTRIBUTE> ACTIVITY_INSTANCE_ATTRIBUTE { get; set; }
        public virtual ICollection<ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE> ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE { get; set; }
        public virtual ICollection<INDIVIDUAL_INSTANCE> INDIVIDUAL_INSTANCE { get; set; }
        public virtual ICollection<RG_INDIVIDUAL_REGISTRATION> RG_INDIVIDUAL_REGISTRATION { get; set; }
        public virtual ICollection<RG_ACTIVITY_REGISTRATION_SCHEDULE> RG_ACTIVITY_REGISTRATION_SCHEDULE { get; set; }
        public virtual ICollection<STAFFING_SCHEDULE_EDIT> STAFFING_SCHEDULE_EDIT { get; set; }
    }
}
