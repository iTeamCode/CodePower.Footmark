using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_INDIVIDUAL_SET
    {
        public FORM_INDIVIDUAL_SET()
        {
            this.FORM_INDIVIDUAL = new List<FORM_INDIVIDUAL>();
            this.FORM_INDIVIDUAL_SET_NOTE = new List<FORM_INDIVIDUAL_SET_NOTE>();
        }

        public int FORM_INDIVIDUAL_SET_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> PAY_ORDER_SET_ID { get; set; }
        public string CONFIRMATION_CODE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<FORM_INDIVIDUAL> FORM_INDIVIDUAL { get; set; }
        public virtual ICollection<FORM_INDIVIDUAL_SET_NOTE> FORM_INDIVIDUAL_SET_NOTE { get; set; }
        public virtual PAY_ORDER_SET PAY_ORDER_SET { get; set; }
    }
}
