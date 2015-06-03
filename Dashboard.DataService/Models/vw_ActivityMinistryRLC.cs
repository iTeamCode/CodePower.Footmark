using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class vw_ActivityMinistryRLC
    {
        public int Church_ID { get; set; }
        public int Ministry_ID { get; set; }
        public Nullable<int> Activity_ID { get; set; }
        public Nullable<int> Activity_Detail_ID { get; set; }
        public string Ministry_Name { get; set; }
        public string Activity_Name { get; set; }
        public string Activity_Detail_Name { get; set; }
        public bool Ministry_Active { get; set; }
        public Nullable<bool> Activity_Active { get; set; }
        public Nullable<bool> RLC_Active { get; set; }
    }
}
