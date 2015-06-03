using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class STAFFING_SCHEDULE_INSTANCE
    {
        public int individual_id { get; set; }
        public int individual_type_id { get; set; }
        public int activity_id { get; set; }
        public int activity_time_id { get; set; }
        public int activity_instance_id { get; set; }
        public System.DateTime start_date_time { get; set; }
        public string end_date_time { get; set; }
        public Nullable<int> activity_detail_id { get; set; }
        public Nullable<int> job_id { get; set; }
        public int church_id { get; set; }
        public int staffing_schedule_id { get; set; }
    }
}
