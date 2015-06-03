using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class MULTIPLE_DISCOUNT
    {
        public int MULTIPLE_DISCOUNT_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int ACTIVITY_REGISTRATION_ID { get; set; }
        public int MINIMUM_REGISTRATIONS { get; set; }
        public decimal DISCOUNT_AMOUNT { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ACTIVITY_REGISTRATION ACTIVITY_REGISTRATION { get; set; }
    }
}
