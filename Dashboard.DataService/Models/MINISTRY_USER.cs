using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class MINISTRY_USER
    {
        public int MINISTRY_ID { get; set; }
        public int USER_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> SECURITY_TYPE_ID { get; set; }
    }
}
