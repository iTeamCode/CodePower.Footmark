using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class GFT_JOB
    {
        public GFT_JOB()
        {
            this.GFT_JOB_ATTRIBUTE = new List<GFT_JOB_ATTRIBUTE>();
            this.GFT_JOB_CATEGORY = new List<GFT_JOB_CATEGORY>();
        }

        public int GFT_JOB_ID { get; set; }
        public int GFT_PROGRAM_ID { get; set; }
        public Nullable<int> JOB_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public System.DateTime ASSESSMENT_DATE { get; set; }
        public bool IS_TEMPLATE { get; set; }
        public string TEMPLATE_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<GFT_JOB_ATTRIBUTE> GFT_JOB_ATTRIBUTE { get; set; }
        public virtual ICollection<GFT_JOB_CATEGORY> GFT_JOB_CATEGORY { get; set; }
    }
}