using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_PRICING_ITEM
    {
        public PAY_PRICING_ITEM()
        {
            this.FORM_ITEM_OPTION = new List<FORM_ITEM_OPTION>();
            this.PAY_LINE_ITEM = new List<PAY_LINE_ITEM>();
        }

        public int PAY_PRICING_ITEM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public decimal PRICE { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public bool IS_DEFAULT { get; set; }
        public int PAY_ITEM_ID { get; set; }
        public virtual ICollection<FORM_ITEM_OPTION> FORM_ITEM_OPTION { get; set; }
        public virtual PAY_ITEM PAY_ITEM { get; set; }
        public virtual ICollection<PAY_LINE_ITEM> PAY_LINE_ITEM { get; set; }
    }
}
