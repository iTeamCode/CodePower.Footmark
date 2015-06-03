using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_REGISTRATION
    {
        public ACTIVITY_REGISTRATION()
        {
            this.ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE = new List<ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE>();
            this.ACTIVITY_REGISTRATION_ACTIVITY_TIME = new List<ACTIVITY_REGISTRATION_ACTIVITY_TIME>();
            this.ACTIVITY_REGISTRATION_JOIN = new List<ACTIVITY_REGISTRATION_JOIN>();
            this.ACTIVITY_REGISTRATION_JOIN1 = new List<ACTIVITY_REGISTRATION_JOIN>();
            this.MULTIPLE_DISCOUNT = new List<MULTIPLE_DISCOUNT>();
            this.PROMOTION_CODE = new List<PROMOTION_CODE>();
            this.REGISTRATION_ACTIVITY_DETAIL = new List<REGISTRATION_ACTIVITY_DETAIL>();
            this.REGISTRATION_GROUP = new List<REGISTRATION_GROUP>();
            this.REGISTRATION_INSTANCE = new List<REGISTRATION_INSTANCE>();
            this.REGISTRATION_PAYMENT_2 = new List<REGISTRATION_PAYMENT_2>();
        }

        public int ACTIVITY_REGISTRATION_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string ACTIVITY_REGISTRATION_NAME { get; set; }
        public int ACTIVITY_ID { get; set; }
        public Nullable<int> ACTIVITY_DETAIL_ID { get; set; }
        public int REGISTER_DETAIL_BY { get; set; }
        public System.DateTime START_DATE_TIME { get; set; }
        public System.DateTime END_DATE_TIME { get; set; }
        public long ENABLED { get; set; }
        public string FORM_CODE { get; set; }
        public bool EMAIL_CONFIRMATION { get; set; }
        public string CONFIRMATION_MESSAGE { get; set; }
        public string COMPLETION_REDIRECT_URL { get; set; }
        public bool RESTRICT_AGE { get; set; }
        public bool IS_VOLUNTEER { get; set; }
        public bool AUTO_FEED_PREFS { get; set; }
        public Nullable<System.DateTime> AGE_CUTOFF_DATE { get; set; }
        public Nullable<int> MERCHANT_ACCOUNT_ID { get; set; }
        public Nullable<int> CONTACT_ITEM_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ICollection<ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE> ACTIVITY_REGISTRATION_ACTIVITY_INSTANCE { get; set; }
        public virtual ICollection<ACTIVITY_REGISTRATION_ACTIVITY_TIME> ACTIVITY_REGISTRATION_ACTIVITY_TIME { get; set; }
        public virtual ICollection<ACTIVITY_REGISTRATION_JOIN> ACTIVITY_REGISTRATION_JOIN { get; set; }
        public virtual ICollection<ACTIVITY_REGISTRATION_JOIN> ACTIVITY_REGISTRATION_JOIN1 { get; set; }
        public virtual ICollection<MULTIPLE_DISCOUNT> MULTIPLE_DISCOUNT { get; set; }
        public virtual ICollection<PROMOTION_CODE> PROMOTION_CODE { get; set; }
        public virtual ICollection<REGISTRATION_ACTIVITY_DETAIL> REGISTRATION_ACTIVITY_DETAIL { get; set; }
        public virtual ICollection<REGISTRATION_GROUP> REGISTRATION_GROUP { get; set; }
        public virtual ICollection<REGISTRATION_INSTANCE> REGISTRATION_INSTANCE { get; set; }
        public virtual ICollection<REGISTRATION_PAYMENT_2> REGISTRATION_PAYMENT_2 { get; set; }
    }
}
