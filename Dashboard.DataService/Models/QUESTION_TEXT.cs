using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class QUESTION_TEXT
    {
        public QUESTION_TEXT()
        {
            this.ACTIVITY_DETAIL_ATTRIBUTE = new List<ACTIVITY_DETAIL_ATTRIBUTE>();
        }

        public int QUESTION_TEXT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int DATA_TYPE_ID { get; set; }
        public Nullable<int> OPTION_TABLE_ID { get; set; }
        public string QUESTION_TEXT1 { get; set; }
        public string OPTIONAL_TEXT { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_REQUIRED { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public string DELETED_BY_LOGIN { get; set; }
        public Nullable<int> DELETED_BY_USER_ID { get; set; }
        public Nullable<byte> IS_DELETED { get; set; }
        public virtual ICollection<ACTIVITY_DETAIL_ATTRIBUTE> ACTIVITY_DETAIL_ATTRIBUTE { get; set; }
        public virtual CURRENCY_ITEM CURRENCY_ITEM { get; set; }
        public virtual DATA_TYPE DATA_TYPE { get; set; }
        public virtual INTEGER_ITEM INTEGER_ITEM { get; set; }
        public virtual OPTION_TABLE OPTION_TABLE { get; set; }
        public virtual TEXT_ITEM TEXT_ITEM { get; set; }
    }
}
