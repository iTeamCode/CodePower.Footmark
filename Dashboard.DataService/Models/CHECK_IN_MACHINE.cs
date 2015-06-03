using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class CHECK_IN_MACHINE
    {
        public int CHECK_IN_MACHINE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string INSTALL_CODE { get; set; }
        public string MACHINE_NAME { get; set; }
        public string APP_VERSION { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
        public string OS_VERSION { get; set; }
        public string CLR_VERSION { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
    }
}
