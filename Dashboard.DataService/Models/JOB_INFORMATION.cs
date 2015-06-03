using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class JOB_INFORMATION
    {
        public JOB_INFORMATION()
        {
            this.JOB_JOB_INFORMATION = new List<JOB_JOB_INFORMATION>();
        }

        public int JOB_INFORMATION_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string JOB_INFORMATION_NAME { get; set; }
        public int MAX_LENGTH { get; set; }
        public bool REQUIRED { get; set; }
        public int SORT { get; set; }
        public bool SHOW_ON_ASSESSMENT_REPORT { get; set; }
        public bool IS_ACTIVE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<JOB_JOB_INFORMATION> JOB_JOB_INFORMATION { get; set; }
    }
}
