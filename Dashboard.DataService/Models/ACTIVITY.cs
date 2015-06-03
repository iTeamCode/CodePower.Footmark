using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY
    {
        public ACTIVITY()
        {
            this.ACTIVITY_DETAIL = new List<ACTIVITY_DETAIL>();
            this.ACTIVITY_EXPERIENCE = new List<ACTIVITY_EXPERIENCE>();
            this.ACTIVITY_EXPERIENCE_REQUIREMENT = new List<ACTIVITY_EXPERIENCE_REQUIREMENT>();
            this.ACTIVITY_GROUP = new List<ACTIVITY_GROUP>();
            this.ACTIVITY_INSTANCE = new List<ACTIVITY_INSTANCE>();
            this.ACTIVITY_MINISTRY = new List<ACTIVITY_MINISTRY>();
            this.ACTIVITY_PROPERTY = new List<ACTIVITY_PROPERTY>();
            this.ACTIVITY_REGISTRATION = new List<ACTIVITY_REGISTRATION>();
            this.ACTIVITY_REQUIREMENT = new List<ACTIVITY_REQUIREMENT>();
            this.ACTIVITY_SERIES = new List<ACTIVITY_SERIES>();
            this.ACTIVITY_TAG = new List<ACTIVITY_TAG>();
            this.ACTIVITY_TIME = new List<ACTIVITY_TIME>();
            this.ACTIVITY_TYPE_ACTIVITY = new List<ACTIVITY_TYPE_ACTIVITY>();
            this.AUTOMATIC_ATTENDANCE_RULE = new List<AUTOMATIC_ATTENDANCE_RULE>();
            this.FORM_ITEM_OPTION = new List<FORM_ITEM_OPTION>();
            this.FREQ_TAG_COMMENT = new List<FREQ_TAG_COMMENT>();
            this.INDIVIDUAL_CUSTOM_REGISTRATION = new List<INDIVIDUAL_CUSTOM_REGISTRATION>();
            this.INDIVIDUAL_GROUP = new List<INDIVIDUAL_GROUP>();
            this.INDIVIDUAL_PREFS = new List<INDIVIDUAL_PREFS>();
            this.INDIVIDUAL_REGISTRATION = new List<INDIVIDUAL_REGISTRATION>();
            this.JOBs = new List<JOB>();
            this.REGISTRATION_CUSTOM = new List<REGISTRATION_CUSTOM>();
            this.REGISTRATION_PAYMENT_OPTION = new List<REGISTRATION_PAYMENT_OPTION>();
            this.REQUIRED_ACTIVITY_ATTRIBUTE = new List<REQUIRED_ACTIVITY_ATTRIBUTE>();
            this.RG_ACTIVITY_REGISTRATION = new List<RG_ACTIVITY_REGISTRATION>();
            this.STAFFING_NEED = new List<STAFFING_NEED>();
            this.STAFFING_SCHEDULE = new List<STAFFING_SCHEDULE>();
        }

        public int ACTIVITY_ID { get; set; }
        public string ACTIVITY_NAME { get; set; }
        public bool HAS_CHECKIN { get; set; }
        public int CHECKIN_MINUTES_BEFORE { get; set; }
        public bool HAS_NAMETAG { get; set; }
        public bool HAS_RECEIPT { get; set; }
        public Nullable<int> START_AGE { get; set; }
        public Nullable<int> END_AGE { get; set; }
        public Nullable<int> EXTEND_START_AGE { get; set; }
        public Nullable<int> EXTEND_END_AGE { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> CHECKIN_CODE { get; set; }
        public decimal FIXED_TIMES { get; set; }
        public bool HAS_SECURITY_AUTHORIZATION { get; set; }
        public int REQUIRES_REGISTRATION { get; set; }
        public Nullable<bool> TRACK_ATTENDANCE_BY_INDIVIDUAL { get; set; }
        public int INDIVIDUAL_PREF_BY { get; set; }
        public int STAFFING_PREF_BY { get; set; }
        public bool DETAIL_BY_ACTIVITY_TIME { get; set; }
        public bool INDIVIDUAL_PREFS_OVERRIDE_CLOSED_ROOM { get; set; }
        public int AUTO_PREF_OPTION { get; set; }
        public Nullable<int> CONTACT_ITEM_ID { get; set; }
        public Nullable<bool> WEB_ENABLED { get; set; }
        public Nullable<int> OLD_ACT_ID { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
        public Nullable<bool> PAGER_ENABLED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> THEME_ID { get; set; }
        public string description { get; set; }
        public bool EnforceAssignmentCreateRules { get; set; }
        public virtual ICollection<ACTIVITY_DETAIL> ACTIVITY_DETAIL { get; set; }
        public virtual ICollection<ACTIVITY_EXPERIENCE> ACTIVITY_EXPERIENCE { get; set; }
        public virtual ICollection<ACTIVITY_EXPERIENCE_REQUIREMENT> ACTIVITY_EXPERIENCE_REQUIREMENT { get; set; }
        public virtual ICollection<ACTIVITY_GROUP> ACTIVITY_GROUP { get; set; }
        public virtual ICollection<ACTIVITY_INSTANCE> ACTIVITY_INSTANCE { get; set; }
        public virtual ICollection<ACTIVITY_MINISTRY> ACTIVITY_MINISTRY { get; set; }
        public virtual ICollection<ACTIVITY_PROPERTY> ACTIVITY_PROPERTY { get; set; }
        public virtual ICollection<ACTIVITY_REGISTRATION> ACTIVITY_REGISTRATION { get; set; }
        public virtual ICollection<ACTIVITY_REQUIREMENT> ACTIVITY_REQUIREMENT { get; set; }
        public virtual ICollection<ACTIVITY_SERIES> ACTIVITY_SERIES { get; set; }
        public virtual ICollection<ACTIVITY_TAG> ACTIVITY_TAG { get; set; }
        public virtual ICollection<ACTIVITY_TIME> ACTIVITY_TIME { get; set; }
        public virtual ICollection<ACTIVITY_TYPE_ACTIVITY> ACTIVITY_TYPE_ACTIVITY { get; set; }
        public virtual ICollection<AUTOMATIC_ATTENDANCE_RULE> AUTOMATIC_ATTENDANCE_RULE { get; set; }
        public virtual ICollection<FORM_ITEM_OPTION> FORM_ITEM_OPTION { get; set; }
        public virtual ICollection<FREQ_TAG_COMMENT> FREQ_TAG_COMMENT { get; set; }
        public virtual ICollection<INDIVIDUAL_CUSTOM_REGISTRATION> INDIVIDUAL_CUSTOM_REGISTRATION { get; set; }
        public virtual ICollection<INDIVIDUAL_GROUP> INDIVIDUAL_GROUP { get; set; }
        public virtual ICollection<INDIVIDUAL_PREFS> INDIVIDUAL_PREFS { get; set; }
        public virtual ICollection<INDIVIDUAL_REGISTRATION> INDIVIDUAL_REGISTRATION { get; set; }
        public virtual ICollection<JOB> JOBs { get; set; }
        public virtual ICollection<REGISTRATION_CUSTOM> REGISTRATION_CUSTOM { get; set; }
        public virtual ICollection<REGISTRATION_PAYMENT_OPTION> REGISTRATION_PAYMENT_OPTION { get; set; }
        public virtual ICollection<REQUIRED_ACTIVITY_ATTRIBUTE> REQUIRED_ACTIVITY_ATTRIBUTE { get; set; }
        public virtual ICollection<RG_ACTIVITY_REGISTRATION> RG_ACTIVITY_REGISTRATION { get; set; }
        public virtual ICollection<STAFFING_NEED> STAFFING_NEED { get; set; }
        public virtual ICollection<STAFFING_SCHEDULE> STAFFING_SCHEDULE { get; set; }
    }
}
