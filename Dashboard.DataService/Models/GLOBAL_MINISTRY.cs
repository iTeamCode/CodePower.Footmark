using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class GLOBAL_MINISTRY
    {
        public GLOBAL_MINISTRY()
        {
            this.MINISTRies = new List<MINISTRY>();
        }

        public int GLOBAL_MINISTRY_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string GLOBAL_MINISTRY_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<MINISTRY> MINISTRies { get; set; }
    }
}
