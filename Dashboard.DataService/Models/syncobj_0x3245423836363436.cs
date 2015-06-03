using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class syncobj_0x3245423836363436
    {
        public int STAFFING_RECURRENCE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int STAFFING_SCHEDULE_ID { get; set; }
        public System.DateTime START_DATE { get; set; }
        public bool NO_END_DATE { get; set; }
        public int END_AFTER_OCCURENCES { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public int RECURRENCE_PATTERN { get; set; }
        public int DAILY_EVERY_DAYS { get; set; }
        public int WEEKLY_EVERY_WEEKS { get; set; }
        public bool WEEKLY_SUNDAY { get; set; }
        public bool WEEKLY_MONDAY { get; set; }
        public bool WEEKLY_TUESDAY { get; set; }
        public bool WEEKLY_WEDNESDAY { get; set; }
        public bool WEEKLY_THURSDAY { get; set; }
        public bool WEEKLY_FRIDAY { get; set; }
        public bool WEEKLY_SATURDAY { get; set; }
        public int MONTHLY_DAY_MONTH { get; set; }
        public int MONTHLY_EVERY_MONTH { get; set; }
        public int MONTHLY_WEEK { get; set; }
        public int MONTHLY_DAY_OF_WEEK { get; set; }
        public int YEARLY_EVERY_MONTH { get; set; }
        public int YEARLY_DAY_MONTH { get; set; }
        public int YEARLY_WEEK { get; set; }
        public int YEARLY_DAY_OF_WEEK { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
    }
}