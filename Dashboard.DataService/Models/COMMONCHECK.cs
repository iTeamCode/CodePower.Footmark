using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class COMMONCHECK
    {
        public int CHECK_ID { get; set; }
        public int CHURCH_ID { get; set; }
        public int INDIVIDUAL_ID { get; set; }
        public string CHECK_ROUTING_NUMBER { get; set; }
        public string CHECK_ACCOUNT_NUMBER { get; set; }
        public string CHECK_NAME { get; set; }
        public string CHECK_ADD1 { get; set; }
        public string CHECK_ADD2 { get; set; }
        public string CHECK_CITY { get; set; }
        public string CHECK_STATE { get; set; }
        public string CHECK_POSTAL_CODE { get; set; }
        public string CHECK_PHONE { get; set; }
        public Nullable<System.DateTime> LAST_REGISTRATION { get; set; }
        public string CHECK_BANK_NAME { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public string CHECK_ADD3 { get; set; }
        public string CHECK_COUNTRY { get; set; }
    }
}
