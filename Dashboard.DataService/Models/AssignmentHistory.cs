using System;
using System.Collections.Generic;

namespace Selenium.DataService.Models
{
    public partial class AssignmentHistory
    {
        public int ChurchID { get; set; }
        public int IndividualID { get; set; }
        public string AssignmentType { get; set; }
        public Nullable<int> IndividualPrefID { get; set; }
        public Nullable<int> StaffingPrefID { get; set; }
        public Nullable<int> PriorActivityID { get; set; }
        public Nullable<int> PriorActivityDetailID { get; set; }
        public Nullable<int> PriorActivityInstanceID { get; set; }
        public Nullable<int> PriorActivityTimeID { get; set; }
        public Nullable<int> PriorIndividualGroupID { get; set; }
        public Nullable<int> PriorIndividualTypeID { get; set; }
        public Nullable<int> PriorStaffingScheduleID { get; set; }
        public Nullable<int> PriorJobID { get; set; }
        public Nullable<int> PriorActivityGroupID { get; set; }
        public Nullable<bool> PriorIsActive { get; set; }
        public Nullable<int> NewActivityID { get; set; }
        public Nullable<int> NewActivityDetailID { get; set; }
        public Nullable<int> NewActivityInstanceID { get; set; }
        public Nullable<int> NewActivityTimeID { get; set; }
        public Nullable<int> NewIndividualGroupID { get; set; }
        public Nullable<int> NewIndividualTypeID { get; set; }
        public Nullable<int> NewStaffingScheduleID { get; set; }
        public Nullable<int> NewJobID { get; set; }
        public Nullable<int> NewActivityGroupID { get; set; }
        public Nullable<bool> NewIsActive { get; set; }
        public Nullable<int> MassActionID { get; set; }
        public System.DateTime AssignmentHistoryDate { get; set; }
    }
}
