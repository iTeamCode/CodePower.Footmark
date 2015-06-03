using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REFERENCE_INTERVIEW
    {
        public int REFERENCE_ID { get; set; }
        public int REFERENCE_QUESTION_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public int REFERENCE_INSTANCE_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual REFERENCE REFERENCE { get; set; }
        public virtual REFERENCE_INSTANCE REFERENCE_INSTANCE { get; set; }
        public virtual REFERENCE_QUESTION REFERENCE_QUESTION { get; set; }
    }
}