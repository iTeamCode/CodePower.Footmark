using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_INSTANCE
    {
        public int INDIVIDUAL_INSTANCE_ID { get; set; }
        public Nullable<int> INDIVIDUAL_ID { get; set; }
        public Nullable<int> VISITOR_ID { get; set; }
        public int INDIVIDUAL_TYPE_ID { get; set; }
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public int ACTIVITY_DETAIL_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string TAG_COMMENT { get; set; }
        public string TAG_CODE { get; set; }
        public Nullable<int> INDIVIDUAL_GROUP_ID { get; set; }
        public Nullable<int> CHECK_IN_MACHINE_ID { get; set; }
        public Nullable<System.DateTime> CHECK_IN_TIME { get; set; }
        public Nullable<System.DateTime> CHECK_OUT_TIME { get; set; }
        public string PAGER_CODE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<int> JOB_ID { get; set; }
        public Nullable<int> TIME_SERVED { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate_Computed { get; set; }
        public virtual ACTIVITY_DETAIL ACTIVITY_DETAIL { get; set; }
        public virtual ACTIVITY_INSTANCE ACTIVITY_INSTANCE { get; set; }
        public virtual INDIVIDUAL_GROUP INDIVIDUAL_GROUP { get; set; }
        public virtual INDIVIDUAL_TYPE INDIVIDUAL_TYPE { get; set; }
        public virtual VISITOR VISITOR { get; set; }
    }
}
