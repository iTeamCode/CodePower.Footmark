using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class syncobj_0x3445454641374145
    {
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
    }
}
