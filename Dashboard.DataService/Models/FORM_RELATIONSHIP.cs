using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class FORM_RELATIONSHIP
    {
        public int FORM1_ID { get; set; }
        public int FORM2_ID { get; set; }
        public int FORM_RELATIONSHIP_TYPE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public virtual FORM FORM { get; set; }
        public virtual FORM FORM1 { get; set; }
        public virtual FORM_RELATIONSHIP_TYPE FORM_RELATIONSHIP_TYPE { get; set; }
    }
}
