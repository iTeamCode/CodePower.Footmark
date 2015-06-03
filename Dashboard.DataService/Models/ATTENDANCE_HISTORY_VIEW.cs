using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class ATTENDANCE_HISTORY_VIEW
    {
        public int CHURCH_ID { get; set; }
        public int MINISTRY_ID { get; set; }
        public string MINISTRY_NAME { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string ACTIVITY_NAME { get; set; }
        public int ROOM_LOCATION_CLASS_ID { get; set; }
        public string ROOM_LOCATION_CLASS_NAME { get; set; }
        public string ACTIVITY_GROUP_NAME { get; set; }
        public Nullable<int> ACTIVITY_GROUP_ID { get; set; }
        public int ACTIVITY_TIME_ID { get; set; }
        public string ACTIVITY_TIME_NAME { get; set; }
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public System.DateTime START_DATE_TIME { get; set; }
        public int STAFF_COUNT { get; set; }
        public int PARTICIPANT_COUNT { get; set; }
    }
}
