using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_RELATIONSHIP_TYPE
    {
        public FORM_RELATIONSHIP_TYPE()
        {
            this.FORM_RELATIONSHIP = new List<FORM_RELATIONSHIP>();
        }

        public int FORM_RELATIONSHIP_TYPE_ID { get; set; }
        public string FORM_RELATIONSHIP_TYPE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual ICollection<FORM_RELATIONSHIP> FORM_RELATIONSHIP { get; set; }
    }
}
