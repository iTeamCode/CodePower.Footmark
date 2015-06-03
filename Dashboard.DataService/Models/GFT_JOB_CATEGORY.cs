using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class GFT_JOB_CATEGORY
    {
        public int GFT_JOB_ID { get; set; }
        public int GFT_CATEGORY_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int CATEGORY_PERCENTAGE { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual GFT_JOB GFT_JOB { get; set; }
    }
}
