using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class EMAIL_MESSAGE
    {
        public EMAIL_MESSAGE()
        {
            this.FORMs = new List<FORM>();
        }

        public int EMAIL_MESSAGE_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string FROM_ADDRESS { get; set; }
        public string CC_LIST { get; set; }
        public string BCC_LIST { get; set; }
        public string SUBJECT { get; set; }
        public string BODY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> DELETED_BY_USER_ID { get; set; }
        public virtual ICollection<FORM> FORMs { get; set; }
    }
}
