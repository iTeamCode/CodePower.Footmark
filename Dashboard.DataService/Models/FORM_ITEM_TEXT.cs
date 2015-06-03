using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_ITEM_TEXT
    {
        public int FORM_ITEM_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> MAX_LENGTH { get; set; }
        public string DEFAULT_VALUE { get; set; }
        public string VALIDATION_EXPRESSION_TYPE { get; set; }
        public string VALIDATION_MESSAGE { get; set; }
        public bool MULTI_LINE { get; set; }
        public Nullable<int> MULTI_BOX { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual FORM_ITEM FORM_ITEM { get; set; }
    }
}
