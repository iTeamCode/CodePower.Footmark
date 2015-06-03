using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class CTRL_DATE_TABLE
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> End_date { get; set; }
        public Nullable<int> processed_ind { get; set; }
    }
}
