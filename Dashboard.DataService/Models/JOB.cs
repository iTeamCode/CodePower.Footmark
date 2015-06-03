using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class JOB
    {
        public JOB()
        {
            this.JOB_JOB_ATTRIBUTE = new List<JOB_JOB_ATTRIBUTE>();
            this.JOB_JOB_INFORMATION = new List<JOB_JOB_INFORMATION>();
            this.JOB_MARITAL_STATUS = new List<JOB_MARITAL_STATUS>();
            this.JOB_REQUIREMENT = new List<JOB_REQUIREMENT>();
            this.JOB_STATUS_RESTRICTION = new List<JOB_STATUS_RESTRICTION>();
            this.STAFFING_NEED = new List<STAFFING_NEED>();
            this.STAFFING_PREF = new List<STAFFING_PREF>();
        }

        public int JOB_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> ACTIVITY_ID { get; set; }
        public string JOB_TITLE { get; set; }
        public string JOB_DESCRIPTION { get; set; }
        public Nullable<int> MINISTRY_ID { get; set; }
        public bool DYD_ENABLED { get; set; }
        public string POSITION_CONTACT { get; set; }
        public Nullable<byte> POSITION_LEVEL { get; set; }
        public Nullable<int> PAYOFF_1 { get; set; }
        public Nullable<int> PAYOFF_2 { get; set; }
        public Nullable<int> SUBJECT_MATTER_1 { get; set; }
        public Nullable<int> SUBJECT_MATTER_2 { get; set; }
        public Nullable<int> SUBJECT_MATTER_3 { get; set; }
        public Nullable<int> CIRCUMSTANCE_1 { get; set; }
        public Nullable<int> CIRCUMSTANCE_2 { get; set; }
        public Nullable<int> CIRCUMSTANCE_3 { get; set; }
        public string GENDER { get; set; }
        public string MARITAL_STATUS { get; set; }
        public Nullable<int> REPORTS_TO_INDIVIDUAL { get; set; }
        public string MINISTRY_PURPOSE { get; set; }
        public string REQUIREMENTS { get; set; }
        public string TRAINING_REQUIREMENTS { get; set; }
        public Nullable<bool> BACKGROUND_CHECK { get; set; }
        public string TIME_COMMITMENT_REQUIRED { get; set; }
        public Nullable<byte> CHRISTIAN_MATURITY_REQUIRED { get; set; }
        public string COMMENTS { get; set; }
        public Nullable<int> ABILITY_1 { get; set; }
        public Nullable<int> ABILITY_2 { get; set; }
        public Nullable<int> ABILITY_3 { get; set; }
        public Nullable<int> ABILITY_4 { get; set; }
        public Nullable<int> ABILITY_5 { get; set; }
        public Nullable<int> ABILITY_6 { get; set; }
        public Nullable<int> MINIMUM_AGE { get; set; }
        public Nullable<int> OLD_JOB_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> CONTACT_INDIVIDUAL_ID { get; set; }
        public Nullable<int> REPORTS_TO_INDIVIDUAL_ID { get; set; }
        public bool ENFORCE_RESTRICTIONS { get; set; }
        public Nullable<int> MAXIMUM_AGE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<int> DEFAULT_TIME_SERVED { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<JOB_JOB_ATTRIBUTE> JOB_JOB_ATTRIBUTE { get; set; }
        public virtual ICollection<JOB_JOB_INFORMATION> JOB_JOB_INFORMATION { get; set; }
        public virtual ICollection<JOB_MARITAL_STATUS> JOB_MARITAL_STATUS { get; set; }
        public virtual ICollection<JOB_REQUIREMENT> JOB_REQUIREMENT { get; set; }
        public virtual ICollection<JOB_STATUS_RESTRICTION> JOB_STATUS_RESTRICTION { get; set; }
        public virtual ICollection<STAFFING_NEED> STAFFING_NEED { get; set; }
        public virtual ICollection<STAFFING_PREF> STAFFING_PREF { get; set; }
    }
}
