using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class INDIVIDUAL_INSTANCE_COUNTS_V
    {
        public int ACTIVITY_INSTANCE_ID { get; set; }
        public int ACTIVITY_DETAIL_ID { get; set; }
        public int ACTIVE_CHECKIN_ID { get; set; }
        public Nullable<int> PARTICIPANTS { get; set; }
        public Nullable<int> VOLUNTEERS { get; set; }
    }
}
