using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_ITEM_OPTION_INDIVIDUAL
    {
        public int FORM_INDIVIDUAL_ID { get; set; }
        public int FORM_ITEM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> FORM_ITEM_OPTION_ID { get; set; }
        public Nullable<int> INDIVIDUAL_PREF_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual FORM_INDIVIDUAL FORM_INDIVIDUAL { get; set; }
        public virtual FORM_ITEM FORM_ITEM { get; set; }
        public virtual FORM_ITEM_OPTION FORM_ITEM_OPTION { get; set; }
        public virtual INDIVIDUAL_PREFS INDIVIDUAL_PREFS { get; set; }
    }
}
