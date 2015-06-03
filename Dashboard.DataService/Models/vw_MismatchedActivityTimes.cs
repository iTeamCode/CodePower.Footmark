using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class vw_MismatchedActivityTimes
    {
        public int ACTIVITY_TIME_ID { get; set; }
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string ACTIVITY_TIME_NAME { get; set; }
        public System.DateTime ACTIVITY_START_TIME { get; set; }
        public Nullable<System.DateTime> ACTIVITY_END_TIME { get; set; }
        public System.DateTime START_DATE_TIME { get; set; }
        public Nullable<System.DateTime> START_CHECKIN { get; set; }
        public Nullable<System.DateTime> END_CHECKIN { get; set; }
    }
}
