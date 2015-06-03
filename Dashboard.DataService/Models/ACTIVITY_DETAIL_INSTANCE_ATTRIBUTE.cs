using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE
    {
        public int ACTIVITY_DETAIL_INSTANCE_ID { get; set; }
        public int ACTIVITY_DETAIL_ATTRIBUTE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string TEXT_ANSWER { get; set; }
        public Nullable<int> INTEGER_ANSWER { get; set; }
        public Nullable<System.DateTime> DATE_ANSWER { get; set; }
        public Nullable<decimal> CURRENCY_ANSWER { get; set; }
        public Nullable<bool> BOOLEAN_ANSWER { get; set; }
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
        public virtual ACTIVITY_DETAIL_ATTRIBUTE ACTIVITY_DETAIL_ATTRIBUTE { get; set; }
        public virtual ACTIVITY_DETAIL_INSTANCE ACTIVITY_DETAIL_INSTANCE { get; set; }
    }
}