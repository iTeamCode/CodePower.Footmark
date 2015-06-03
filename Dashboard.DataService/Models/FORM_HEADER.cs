using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_HEADER
    {
        public FORM_HEADER()
        {
            this.FORM_ITEM = new List<FORM_ITEM>();
        }

        public int FORM_HEADER_ID { get; set; }
        public int FORM_PAGE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string FORM_HEADER_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<int> SORT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public bool IsShared { get; set; }
        public virtual FORM_PAGE FORM_PAGE { get; set; }
        public virtual ICollection<FORM_ITEM> FORM_ITEM { get; set; }
    }
}
