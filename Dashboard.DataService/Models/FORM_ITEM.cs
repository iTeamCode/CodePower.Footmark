using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_ITEM
    {
        public FORM_ITEM()
        {
            this.FORM_ITEM_OPTION_INDIVIDUAL = new List<FORM_ITEM_OPTION_INDIVIDUAL>();
            this.FORM_ITEM_OPTION = new List<FORM_ITEM_OPTION>();
            this.FORM_ITEM_TEXT_INDIVIDUAL = new List<FORM_ITEM_TEXT_INDIVIDUAL>();
        }

        public int FORM_ITEM_ID { get; set; }
        public int FORM_HEADER_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int FORM_ITEM_TYPE_ID { get; set; }
        public string TEXT { get; set; }
        public Nullable<bool> REQUIRED { get; set; }
        public int SORT { get; set; }
        public bool IS_ACTIVE { get; set; }
        public string OPTIONAL_TEXT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual FORM_HEADER FORM_HEADER { get; set; }
        public virtual FORM_ITEM_TYPE FORM_ITEM_TYPE { get; set; }
        public virtual ICollection<FORM_ITEM_OPTION_INDIVIDUAL> FORM_ITEM_OPTION_INDIVIDUAL { get; set; }
        public virtual ICollection<FORM_ITEM_OPTION> FORM_ITEM_OPTION { get; set; }
        public virtual ICollection<FORM_ITEM_TEXT_INDIVIDUAL> FORM_ITEM_TEXT_INDIVIDUAL { get; set; }
        public virtual FORM_ITEM_TEXT FORM_ITEM_TEXT { get; set; }
    }
}
