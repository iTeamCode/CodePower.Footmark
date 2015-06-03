using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_PAGE
    {
        public FORM_PAGE()
        {
            this.FORM_HEADER = new List<FORM_HEADER>();
        }

        public int FORM_PAGE_ID { get; set; }
        public int FORM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string FORM_PAGE_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<int> SORT { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual FORM FORM { get; set; }
        public virtual ICollection<FORM_HEADER> FORM_HEADER { get; set; }
    }
}
