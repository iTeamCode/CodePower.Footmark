using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class REFERENCE_QUESTION
    {
        public REFERENCE_QUESTION()
        {
            this.REFERENCE_INTERVIEW = new List<REFERENCE_INTERVIEW>();
            this.REFERENCE_ITEM_LOV = new List<REFERENCE_ITEM_LOV>();
            this.VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM = new List<VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM>();
        }

        public int REFERENCE_QUESTION_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string ANSWER_TYPE_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual ICollection<REFERENCE_INTERVIEW> REFERENCE_INTERVIEW { get; set; }
        public virtual ICollection<REFERENCE_ITEM_LOV> REFERENCE_ITEM_LOV { get; set; }
        public virtual ICollection<VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM> VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM { get; set; }
    }
}
