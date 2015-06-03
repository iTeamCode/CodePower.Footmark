using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ELEMENT
    {
        public ELEMENT()
        {
            this.COLOR_SET_ELEMENT = new List<COLOR_SET_ELEMENT>();
        }

        public int ELEMENT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string ELEMENT_NAME { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public int CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public string DELETED_BY_LOGIN { get; set; }
        public Nullable<int> DELETED_BY_USER_ID { get; set; }
        public int IS_DELETED { get; set; }
        public virtual ICollection<COLOR_SET_ELEMENT> COLOR_SET_ELEMENT { get; set; }
    }
}
