using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.Model
{
    public partial class Individual
    {
        public Individual()
        {
            //this.COMPANY_INDIVIDUAL = new List<COMPANY_INDIVIDUAL>();
            //this.DYD_INDIVIDUAL_ASSESSMENT = new List<DYD_INDIVIDUAL_ASSESSMENT>();
            //this.EXPERIENCEs = new List<EXPERIENCE>();
            //this.GFT_INDIVIDUAL = new List<GFT_INDIVIDUAL>();
            //this.Group_Member = new List<Group_Member>();
            //this.HOUSEHOLD_ADDRESS = new List<HOUSEHOLD_ADDRESS>();
            //this.HOUSEHOLD_COMMUNICATION = new List<HOUSEHOLD_COMMUNICATION>();
            //this.INDIVIDUAL_ATTRIBUTE = new List<INDIVIDUAL_ATTRIBUTE>();
            //this.INDIVIDUAL_HOUSEHOLD = new List<INDIVIDUAL_HOUSEHOLD>();
            //this.INDIVIDUAL_INTEREST = new List<INDIVIDUAL_INTEREST>();
            //this.INDIVIDUAL_LIST = new List<INDIVIDUAL_LIST>();
            //this.INDIVIDUAL_RELATIONSHIP_MEMBER = new List<INDIVIDUAL_RELATIONSHIP_MEMBER>();
            //this.INDIVIDUAL_RELATIONSHIP_NOTE = new List<INDIVIDUAL_RELATIONSHIP_NOTE>();
            //this.INDIVIDUAL_RELATIONSHIP_NOTE1 = new List<INDIVIDUAL_RELATIONSHIP_NOTE>();
            //this.INDIVIDUAL_REQUIREMENT = new List<INDIVIDUAL_REQUIREMENT>();
            //this.IndividualCustomFieldValues = new List<IndividualCustomFieldValue>();
            //this.IndividualInformations = new List<IndividualInformation>();
            //this.MEDICAL_RECORD = new List<MEDICAL_RECORD>();
            //this.NOTE_INSTANCE = new List<NOTE_INSTANCE>();
        }

        public int INDIVIDUAL_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int STATUS_ID { get; set; }
        public Nullable<int> STATUS_SELECTLIST_ID { get; set; }
        public Nullable<System.DateTime> STATUS_DATE { get; set; }
        public string STATUS_COMMENT { get; set; }
        public string PREFIX { get; set; }
        public string LAST_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string FORMER_NAME { get; set; }
        public string SUFFIX { get; set; }
        public string GENDER { get; set; }
        public Nullable<System.DateTime> DATE_OF_BIRTH { get; set; }
        public string MARITAL_STATUS { get; set; }
        public Nullable<System.DateTime> FIRST_RECORD { get; set; }
        public Nullable<int> OCCUPATION_ID { get; set; }
        public string OCCUPATION_DESCRIPTION { get; set; }
        public string EMPLOYER { get; set; }
        public Nullable<int> SCHOOL_ID { get; set; }
        public Nullable<int> DENOMINATION_ID { get; set; }
        public string FORMER_CHURCH { get; set; }
        public string GOES_BY { get; set; }
        public string DEFAULT_TAG_COMMENT { get; set; }
        public string OTHER_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
        public string INDIVIDUAL_CODE { get; set; }
        public string UNIQUE_ID { get; set; }
        public string OLD_IND_ID { get; set; }
        public string PASSWORD_HASH { get; set; }
        public string PASSWORD_SALT { get; set; }
        public string PASSWORD_HINT { get; set; }
        public string PASSWORD_ANSWER { get; set; }
        public Nullable<System.DateTime> LAST_MATCH_DATE { get; set; }
        public string BAR_CODE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> old_ind_id2 { get; set; }
        public string MEMBER_ENV_CODE { get; set; }
        public string SALUTATION { get; set; }
        public string TITLE { get; set; }
        public Nullable<bool> SOLICIT { get; set; }
        public Nullable<bool> THANK { get; set; }
        public string Individual_Name { get; set; }
        public Nullable<int> MassActionID { get; set; }
        public Nullable<System.DateTime> RDWAuditDate { get; set; }
        public Nullable<int> PreferredPhoneTypeID { get; set; }
        public Nullable<int> PreferredEmailTypeID { get; set; }
        public Nullable<bool> UnsubscribeAllChurchEmail { get; set; }
        //public virtual ICollection<COMPANY_INDIVIDUAL> COMPANY_INDIVIDUAL { get; set; }
        //public virtual DENOMINATION DENOMINATION { get; set; }
        //public virtual ICollection<DYD_INDIVIDUAL_ASSESSMENT> DYD_INDIVIDUAL_ASSESSMENT { get; set; }
        //public virtual ICollection<EXPERIENCE> EXPERIENCEs { get; set; }
        //public virtual ICollection<GFT_INDIVIDUAL> GFT_INDIVIDUAL { get; set; }
        //public virtual ICollection<Group_Member> Group_Member { get; set; }
        //public virtual ICollection<HOUSEHOLD_ADDRESS> HOUSEHOLD_ADDRESS { get; set; }
        //public virtual ICollection<HOUSEHOLD_COMMUNICATION> HOUSEHOLD_COMMUNICATION { get; set; }
        //public virtual ICollection<INDIVIDUAL_ATTRIBUTE> INDIVIDUAL_ATTRIBUTE { get; set; }
        //public virtual ICollection<INDIVIDUAL_HOUSEHOLD> INDIVIDUAL_HOUSEHOLD { get; set; }
        //public virtual ICollection<INDIVIDUAL_INTEREST> INDIVIDUAL_INTEREST { get; set; }
        //public virtual ICollection<INDIVIDUAL_LIST> INDIVIDUAL_LIST { get; set; }
        //public virtual OCCUPATION OCCUPATION { get; set; }
        //public virtual ICollection<INDIVIDUAL_RELATIONSHIP_MEMBER> INDIVIDUAL_RELATIONSHIP_MEMBER { get; set; }
        //public virtual ICollection<INDIVIDUAL_RELATIONSHIP_NOTE> INDIVIDUAL_RELATIONSHIP_NOTE { get; set; }
        //public virtual ICollection<INDIVIDUAL_RELATIONSHIP_NOTE> INDIVIDUAL_RELATIONSHIP_NOTE1 { get; set; }
        //public virtual ICollection<INDIVIDUAL_REQUIREMENT> INDIVIDUAL_REQUIREMENT { get; set; }
        //public virtual SCHOOL SCHOOL { get; set; }
        //public virtual STATUS STATUS { get; set; }
        //public virtual STATUS_SELECTLIST STATUS_SELECTLIST { get; set; }
        //public virtual ICollection<IndividualCustomFieldValue> IndividualCustomFieldValues { get; set; }
        //public virtual ICollection<IndividualInformation> IndividualInformations { get; set; }
        //public virtual ICollection<MEDICAL_RECORD> MEDICAL_RECORD { get; set; }
        //public virtual ICollection<NOTE_INSTANCE> NOTE_INSTANCE { get; set; }
    }
}
