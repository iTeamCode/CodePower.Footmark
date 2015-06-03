using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class OPTION_TABLE
    {
        public OPTION_TABLE()
        {
            this.QUESTION_TEXT = new List<QUESTION_TEXT>();
        }

        public int OPTION_TABLE_ID { get; set; }
        public string OPTION_TABLE_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<QUESTION_TEXT> QUESTION_TEXT { get; set; }
    }
}
