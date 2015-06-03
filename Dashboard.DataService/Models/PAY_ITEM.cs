using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PAY_ITEM
    {
        public PAY_ITEM()
        {
            this.PAY_ITEM_FORM_ITEM_OPTION = new List<PAY_ITEM_FORM_ITEM_OPTION>();
            this.PAY_ITEM_FORM = new List<PAY_ITEM_FORM>();
            this.PAY_PAYMENT_REQUIREMENT = new List<PAY_PAYMENT_REQUIREMENT>();
            this.PAY_PRICING_ITEM = new List<PAY_PRICING_ITEM>();
        }

        public int PAY_ITEM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int PAY_ITEM_TYPE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual PAY_ITEM_DETAIL PAY_ITEM_DETAIL { get; set; }
        public virtual ICollection<PAY_ITEM_FORM_ITEM_OPTION> PAY_ITEM_FORM_ITEM_OPTION { get; set; }
        public virtual ICollection<PAY_ITEM_FORM> PAY_ITEM_FORM { get; set; }
        public virtual PAY_ITEM_TYPE PAY_ITEM_TYPE { get; set; }
        public virtual ICollection<PAY_PAYMENT_REQUIREMENT> PAY_PAYMENT_REQUIREMENT { get; set; }
        public virtual ICollection<PAY_PRICING_ITEM> PAY_PRICING_ITEM { get; set; }
    }
}
