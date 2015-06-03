using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class AUTOMATIC_ATTENDANCE_RULE
    {
        public int AUTOMATIC_ATTENDANCE_RULE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int MINISTRY_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public int ACTIVITY_DETAIL_ID { get; set; }
        public Nullable<bool> HOUSEHOLD_HEAD_IND { get; set; }
        public Nullable<bool> HOUSEHOLD_SPOUSE_IND { get; set; }
        public Nullable<bool> HOUSEHOLD_CHILD_IND { get; set; }
        public Nullable<bool> CONTRIBUTOR_SPOUSE_IND { get; set; }
        public Nullable<bool> CONTRIBUTOR_CHILD_IND { get; set; }
        public Nullable<bool> CHILD_PARENT_IND { get; set; }
        public Nullable<bool> CHILD_SIBLING_IND { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY ACTIVITY { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual MINISTRY MINISTRY { get; set; }
    }
}
