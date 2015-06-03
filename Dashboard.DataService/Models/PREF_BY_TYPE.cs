using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class PREF_BY_TYPE
    {
        public int PREF_BY_TYPE_ID { get; set; }
        public string PREF_BY_TYPE_NAME { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public System.DateTime LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
    }
}
