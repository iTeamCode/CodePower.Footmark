using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_ITEM_OPTION
    {
        public FORM_ITEM_OPTION()
        {
            this.FORM_ITEM_OPTION_INDIVIDUAL = new List<FORM_ITEM_OPTION_INDIVIDUAL>();
            this.PAY_ITEM_FORM_ITEM_OPTION = new List<PAY_ITEM_FORM_ITEM_OPTION>();
        }

        public int FORM_ITEM_OPTION_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int FORM_ITEM_ID { get; set; }
        public Nullable<int> ACTIVITY_ID { get; set; }
        public Nullable<int> ACTIVITY_DETAIL_ID { get; set; }
        public Nullable<int> INDIVIDUAL_GROUP_ID { get; set; }
        public string TEXT { get; set; }
        public string OPTION_VALUE { get; set; }
        public Nullable<int> PAY_PRICING_ITEM_ID { get; set; }
        public bool IS_DEFAULT { get; set; }
        public Nullable<int> SORT { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual FORM_ITEM FORM_ITEM { get; set; }
        public virtual ICollection<FORM_ITEM_OPTION_INDIVIDUAL> FORM_ITEM_OPTION_INDIVIDUAL { get; set; }
        public virtual INDIVIDUAL_GROUP INDIVIDUAL_GROUP { get; set; }
        public virtual PAY_PRICING_ITEM PAY_PRICING_ITEM { get; set; }
        public virtual ICollection<PAY_ITEM_FORM_ITEM_OPTION> PAY_ITEM_FORM_ITEM_OPTION { get; set; }
    }
}
