using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_INDIVIDUAL
    {
        public FORM_INDIVIDUAL()
        {
            this.FORM_ITEM_OPTION_INDIVIDUAL = new List<FORM_ITEM_OPTION_INDIVIDUAL>();
            this.FORM_ITEM_TEXT_INDIVIDUAL = new List<FORM_ITEM_TEXT_INDIVIDUAL>();
        }

        public int FORM_INDIVIDUAL_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public int FORM_ID { get; set; }
        public int FORM_INDIVIDUAL_SET_ID { get; set; }
        public int FORM_INDIVIDUAL_STATUS_TYPE_ID { get; set; }
        public Nullable<System.DateTime> SUBMIT_DATE { get; set; }
        public Nullable<int> PAY_ORDER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual FORM FORM { get; set; }
        public virtual FORM_INDIVIDUAL_SET FORM_INDIVIDUAL_SET { get; set; }
        public virtual FORM_INDIVIDUAL_STATUS_TYPE FORM_INDIVIDUAL_STATUS_TYPE { get; set; }
        public virtual PAY_ORDER PAY_ORDER { get; set; }
        public virtual ICollection<FORM_ITEM_OPTION_INDIVIDUAL> FORM_ITEM_OPTION_INDIVIDUAL { get; set; }
        public virtual ICollection<FORM_ITEM_TEXT_INDIVIDUAL> FORM_ITEM_TEXT_INDIVIDUAL { get; set; }
        public virtual RG_INDIVIDUAL_REGISTRATION RG_INDIVIDUAL_REGISTRATION { get; set; }
    }
}
