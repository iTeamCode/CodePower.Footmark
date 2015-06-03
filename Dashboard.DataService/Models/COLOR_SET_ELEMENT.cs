using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class COLOR_SET_ELEMENT
    {
        public int COLOR_SET_ELEMENT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int COLOR_SET_ID { get; set; }
        public int ELEMENT_ID { get; set; }
        public string ELEMENT_VALUE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public int CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public string DELETED_BY_LOGIN { get; set; }
        public Nullable<int> DELETED_BY_USER_ID { get; set; }
        public virtual COLOR_SET COLOR_SET { get; set; }
        public virtual ELEMENT ELEMENT { get; set; }
    }
}
