using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_DETAIL
    {
        public ACTIVITY_DETAIL()
        {
            this.ACTIVE_DETAIL_CHECKIN = new List<ACTIVE_DETAIL_CHECKIN>();
            this.ACTIVITY_DETAIL_INSTANCE = new List<ACTIVITY_DETAIL_INSTANCE>();
            this.ACTIVITY_PROPERTY_ACTIVITY_DETAIL = new List<ACTIVITY_PROPERTY_ACTIVITY_DETAIL>();
            this.AUTOMATIC_ATTENDANCE_RULE = new List<AUTOMATIC_ATTENDANCE_RULE>();
            this.FORM_ITEM_OPTION = new List<FORM_ITEM_OPTION>();
            this.INDIVIDUAL_INSTANCE = new List<INDIVIDUAL_INSTANCE>();
            this.INDIVIDUAL_PREFS = new List<INDIVIDUAL_PREFS>();
            this.INDIVIDUAL_REGISTRATION_2 = new List<INDIVIDUAL_REGISTRATION_2>();
            this.REGISTRATION_ACTIVITY_DETAIL = new List<REGISTRATION_ACTIVITY_DETAIL>();
            this.RG_ACTIVITY_REGISTRATION = new List<RG_ACTIVITY_REGISTRATION>();
            this.STAFFING_PREF = new List<STAFFING_PREF>();
            this.STAFFING_SCHEDULE_EDIT = new List<STAFFING_SCHEDULE_EDIT>();
        }

        public int ACTIVITY_DETAIL_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string ACTIVITY_DETAIL_NAME { get; set; }
        public int ACTIVITY_ID { get; set; }
        public Nullable<int> ACTIVITY_GROUP_ID { get; set; }
        public Nullable<int> DEFAULT_ROOM_ID { get; set; }
        public string OTHER_LOCATION { get; set; }
        public Nullable<bool> CHECKIN_AUTO_OPEN { get; set; }
        public bool CHECKIN_ENABLED { get; set; }
        public Nullable<int> DEFAULT_CAPACITY { get; set; }
        public Nullable<System.DateTime> START_AGE_DATE { get; set; }
        public Nullable<System.DateTime> END_AGE_DATE { get; set; }
        public Nullable<double> DEFAULT_AGE { get; set; }
        public Nullable<bool> HAS_NAMETAG { get; set; }
        public Nullable<bool> HAS_RECEIPT { get; set; }
        public Nullable<int> DEFAULT_INDIVIDUAL_GROUP_ID { get; set; }
        public Nullable<int> ACTIVITY_TIME_ID { get; set; }
        public Nullable<int> OLD_ACT_DET_ID { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
        public Nullable<bool> PAGER_ENABLED { get; set; }
        public Nullable<bool> IS_CLOSED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> OLD_ACT_GRP_ID { get; set; }
        public Nullable<bool> CAN_TRANSFER_CONTACTS { get; set; }
        public Nullable<short> Start_Age_Range { get; set; }
        public Nullable<short> End_Age_Range { get; set; }
        public int Date_Range_Type_ID { get; set; }
        public bool Override_Activity { get; set; }
        public virtual ICollection<ACTIVE_DETAIL_CHECKIN> ACTIVE_DETAIL_CHECKIN { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ACTIVITY_GROUP ACTIVITY_GROUP { get; set; }
        public virtual INDIVIDUAL_GROUP INDIVIDUAL_GROUP { get; set; }
        public virtual ICollection<ACTIVITY_DETAIL_INSTANCE> ACTIVITY_DETAIL_INSTANCE { get; set; }
        public virtual ICollection<ACTIVITY_PROPERTY_ACTIVITY_DETAIL> ACTIVITY_PROPERTY_ACTIVITY_DETAIL { get; set; }
        public virtual ICollection<AUTOMATIC_ATTENDANCE_RULE> AUTOMATIC_ATTENDANCE_RULE { get; set; }
        public virtual ICollection<FORM_ITEM_OPTION> FORM_ITEM_OPTION { get; set; }
        public virtual ICollection<INDIVIDUAL_INSTANCE> INDIVIDUAL_INSTANCE { get; set; }
        public virtual ICollection<INDIVIDUAL_PREFS> INDIVIDUAL_PREFS { get; set; }
        public virtual ICollection<INDIVIDUAL_REGISTRATION_2> INDIVIDUAL_REGISTRATION_2 { get; set; }
        public virtual ICollection<REGISTRATION_ACTIVITY_DETAIL> REGISTRATION_ACTIVITY_DETAIL { get; set; }
        public virtual ICollection<RG_ACTIVITY_REGISTRATION> RG_ACTIVITY_REGISTRATION { get; set; }
        public virtual ICollection<STAFFING_PREF> STAFFING_PREF { get; set; }
        public virtual ICollection<STAFFING_SCHEDULE_EDIT> STAFFING_SCHEDULE_EDIT { get; set; }
    }
}
