using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_V
    {
        public int HOUSEHOLD_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public string ACTIVITY_DETAIL_NAME { get; set; }
        public string ACTIVITY_NAME { get; set; }
        public Nullable<System.DateTime> START_DATE_TIME { get; set; }
        public int HOUSEHOLD_MEMBER_TYPE_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public int INDIVIDUAL_TYPE_ID { get; set; }
        public Nullable<int> JOB_ID { get; set; }
        public string JOB_TITLE { get; set; }
        public int CHURCH_ID { get; set; }
    }
}
