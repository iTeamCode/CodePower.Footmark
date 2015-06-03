using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class TAG_TEMPLATE_ITEM
    {
        public int TAG_TEMPLATE_ITEM_ID { get; set; }
        public int TAG_TEMPLATE_ID { get; set; }
        public int TAG_ITEM_ID { get; set; }
        public Nullable<int> TAG_DATA_FIELD_ID { get; set; }
        public Nullable<int> TAG_LOGO_ID { get; set; }
        public string STATIC_TEXT { get; set; }
        public short START_POINT_X { get; set; }
        public short START_POINT_Y { get; set; }
        public short END_POINT_X { get; set; }
        public short END_POINT_Y { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY_LOGIN { get; set; }
        public Nullable<int> CREATED_BY_USER_ID { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED_DATE { get; set; }
        public string LAST_UPDATED_BY_LOGIN { get; set; }
        public Nullable<int> LAST_UPDATED_BY_USER_ID { get; set; }
        public virtual TAG_DATA_FIELD TAG_DATA_FIELD { get; set; }
        public virtual TAG_ITEM TAG_ITEM { get; set; }
        public virtual TAG_LOGO TAG_LOGO { get; set; }
        public virtual TAG_TEMPLATE TAG_TEMPLATE { get; set; }
    }
}
