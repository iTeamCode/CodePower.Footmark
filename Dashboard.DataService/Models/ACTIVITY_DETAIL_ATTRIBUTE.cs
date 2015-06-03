using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_DETAIL_ATTRIBUTE
    {
        public ACTIVITY_DETAIL_ATTRIBUTE()
        {
            this.ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE = new List<ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE>();
        }

        public int ACTIVITY_DETAIL_ATTRIBUTE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int QUESTION_TEXT_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public Nullable<int> ACTIVITY_DETAIL_ID { get; set; }
        public int SORT { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
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
        public virtual QUESTION_TEXT QUESTION_TEXT { get; set; }
        public virtual ICollection<ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE> ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE { get; set; }
    }
}
