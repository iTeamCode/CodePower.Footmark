using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_TIME
    {
        public ACTIVITY_TIME()
        {
            this.ACTIVITY_RECURRENCE = new List<ACTIVITY_RECURRENCE>();
            this.ACTIVITY_REGISTRATION_ACTIVITY_TIME = new List<ACTIVITY_REGISTRATION_ACTIVITY_TIME>();
            this.ACTIVITY_TIME_ACTIVITY_INSTANCE = new List<ACTIVITY_TIME_ACTIVITY_INSTANCE>();
            this.GLOBAL_ACTIVITY_TIME = new List<GLOBAL_ACTIVITY_TIME>();
            this.RG_INDIVIDUAL_REGISTRATION = new List<RG_INDIVIDUAL_REGISTRATION>();
            this.RG_ACTIVITY_REGISTRATION_SCHEDULE = new List<RG_ACTIVITY_REGISTRATION_SCHEDULE>();
            this.STAFFING_NEED = new List<STAFFING_NEED>();
            this.STAFFING_PREF = new List<STAFFING_PREF>();
        }

        public int ACTIVITY_TIME_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string ACTIVITY_TIME_NAME { get; set; }
        public System.DateTime ACTIVITY_START_TIME { get; set; }
        public Nullable<System.DateTime> ACTIVITY_END_TIME { get; set; }
        public Nullable<int> OLD_ACT_TIME_ID { get; set; }
        public System.DateTime Created_Date { get; set; }
        public Nullable<int> Created_By_User_ID { get; set; }
        public string Created_By_Login { get; set; }
        public Nullable<System.DateTime> Last_Updated_Date { get; set; }
        public string Last_Updated_By_Login { get; set; }
        public Nullable<int> Last_Updated_By_User_ID { get; set; }
        public Nullable<System.DateTime> Max_End_Date { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<ACTIVITY_RECURRENCE> ACTIVITY_RECURRENCE { get; set; }
        public virtual ICollection<ACTIVITY_REGISTRATION_ACTIVITY_TIME> ACTIVITY_REGISTRATION_ACTIVITY_TIME { get; set; }
        public virtual ICollection<ACTIVITY_TIME_ACTIVITY_INSTANCE> ACTIVITY_TIME_ACTIVITY_INSTANCE { get; set; }
        public virtual ICollection<GLOBAL_ACTIVITY_TIME> GLOBAL_ACTIVITY_TIME { get; set; }
        public virtual ICollection<RG_INDIVIDUAL_REGISTRATION> RG_INDIVIDUAL_REGISTRATION { get; set; }
        public virtual ICollection<RG_ACTIVITY_REGISTRATION_SCHEDULE> RG_ACTIVITY_REGISTRATION_SCHEDULE { get; set; }
        public virtual ICollection<STAFFING_NEED> STAFFING_NEED { get; set; }
        public virtual ICollection<STAFFING_PREF> STAFFING_PREF { get; set; }
    }
}
