using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM
    {
        public FORM()
        {
            this.FORM_INDIVIDUAL = new List<FORM_INDIVIDUAL>();
            this.FORM_PAGE = new List<FORM_PAGE>();
            this.FORM_PROMOTION_CODE = new List<FORM_PROMOTION_CODE>();
            this.FORM_RELATIONSHIP = new List<FORM_RELATIONSHIP>();
            this.FORM_RELATIONSHIP1 = new List<FORM_RELATIONSHIP>();
            this.PAY_ITEM_FORM = new List<PAY_ITEM_FORM>();
        }

        public int FORM_ID { get; set; }
        public int FORM_TYPE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string FORM_NAME { get; set; }
        public string FORM_CODE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public Nullable<int> MIN_AGE { get; set; }
        public Nullable<int> MAX_AGE { get; set; }
        public Nullable<int> MAX_CAPACITY { get; set; }
        public Nullable<bool> AGE_UNIT_YEAR { get; set; }
        public Nullable<System.DateTime> AGE_CUTOFF_DATE { get; set; }
        public string GENDER_RESTRICTION { get; set; }
        public Nullable<int> FUND_ID { get; set; }
        public Nullable<int> SUB_FUND_ID { get; set; }
        public Nullable<int> CONTACT_ITEM_ID { get; set; }
        public Nullable<int> CONFIRMATION_EMAIL_MESSAGE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual EMAIL_MESSAGE EMAIL_MESSAGE { get; set; }
        public virtual FORM_TYPE FORM_TYPE { get; set; }
        public virtual ICollection<FORM_INDIVIDUAL> FORM_INDIVIDUAL { get; set; }
        public virtual ICollection<FORM_PAGE> FORM_PAGE { get; set; }
        public virtual ICollection<FORM_PROMOTION_CODE> FORM_PROMOTION_CODE { get; set; }
        public virtual ICollection<FORM_RELATIONSHIP> FORM_RELATIONSHIP { get; set; }
        public virtual ICollection<FORM_RELATIONSHIP> FORM_RELATIONSHIP1 { get; set; }
        public virtual ICollection<PAY_ITEM_FORM> PAY_ITEM_FORM { get; set; }
        public virtual RG_ACTIVITY_REGISTRATION RG_ACTIVITY_REGISTRATION { get; set; }
    }
}
