using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class THEME
    {
        public int THEME_ID { get; set; }
        public string THEME_NAME { get; set; }
        public int CHURCH_ID { get; set; }
        public Nullable<int> COLOR_SET_ID { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public int CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public string DELETED_BY_LOGIN { get; set; }
        public Nullable<int> DELETED_BY_USER_ID { get; set; }
        public int IS_DELETED { get; set; }
        public string BackgroundImage_Path { get; set; }
        public string ConfirmImage_Path { get; set; }
        public string WelcomeImage_Path { get; set; }
        public virtual COLOR_SET COLOR_SET { get; set; }
    }
}
