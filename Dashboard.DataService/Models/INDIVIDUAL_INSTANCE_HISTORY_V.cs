using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_INSTANCE_HISTORY_V
    {
        public Nullable<int> INDIVIDUAL_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int INDIVIDUAL_TYPE_ID { get; set; }
        public string INDIVIDUAL_TYPE_NAME { get; set; }
        public int MINISTRY_ID { get; set; }
        public string MINISTRY_NAME { get; set; }
        public int ACTIVITY_ID { get; set; }
        public string ACTIVITY_NAME { get; set; }
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public System.DateTime START_DATE_TIME { get; set; }
        public int ACTIVITY_DETAIL_ID { get; set; }
        public string ACTIVITY_DETAIL_NAME { get; set; }
        public Nullable<int> INDIVIDUAL_GROUP_ID { get; set; }
        public string INDIVIDUAL_GROUP_NAME { get; set; }
        public int INDIVIDUAL_INSTANCE_ID { get; set; }
    }
}
