using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_INDIVIDUAL_STATUS_TYPE
    {
        public FORM_INDIVIDUAL_STATUS_TYPE()
        {
            this.FORM_INDIVIDUAL = new List<FORM_INDIVIDUAL>();
        }

        public int FORM_INDIVIDUAL_STATUS_TYPE_ID { get; set; }
        public string FORM_INDIVIDUAL_STATUS_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<FORM_INDIVIDUAL> FORM_INDIVIDUAL { get; set; }
    }
}
