using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class AssignmentHistoryMap : EntityTypeConfiguration<AssignmentHistory>
    {
        public AssignmentHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ChurchID, t.IndividualID, t.AssignmentType, t.AssignmentHistoryDate });

            // Properties
            this.Property(t => t.ChurchID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IndividualID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssignmentType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("AssignmentHistory");
            this.Property(t => t.ChurchID).HasColumnName("ChurchID");
            this.Property(t => t.IndividualID).HasColumnName("IndividualID");
            this.Property(t => t.AssignmentType).HasColumnName("AssignmentType");
            this.Property(t => t.IndividualPrefID).HasColumnName("IndividualPrefID");
            this.Property(t => t.StaffingPrefID).HasColumnName("StaffingPrefID");
            this.Property(t => t.PriorActivityID).HasColumnName("PriorActivityID");
            this.Property(t => t.PriorActivityDetailID).HasColumnName("PriorActivityDetailID");
            this.Property(t => t.PriorActivityInstanceID).HasColumnName("PriorActivityInstanceID");
            this.Property(t => t.PriorActivityTimeID).HasColumnName("PriorActivityTimeID");
            this.Property(t => t.PriorIndividualGroupID).HasColumnName("PriorIndividualGroupID");
            this.Property(t => t.PriorIndividualTypeID).HasColumnName("PriorIndividualTypeID");
            this.Property(t => t.PriorStaffingScheduleID).HasColumnName("PriorStaffingScheduleID");
            this.Property(t => t.PriorJobID).HasColumnName("PriorJobID");
            this.Property(t => t.PriorActivityGroupID).HasColumnName("PriorActivityGroupID");
            this.Property(t => t.PriorIsActive).HasColumnName("PriorIsActive");
            this.Property(t => t.NewActivityID).HasColumnName("NewActivityID");
            this.Property(t => t.NewActivityDetailID).HasColumnName("NewActivityDetailID");
            this.Property(t => t.NewActivityInstanceID).HasColumnName("NewActivityInstanceID");
            this.Property(t => t.NewActivityTimeID).HasColumnName("NewActivityTimeID");
            this.Property(t => t.NewIndividualGroupID).HasColumnName("NewIndividualGroupID");
            this.Property(t => t.NewIndividualTypeID).HasColumnName("NewIndividualTypeID");
            this.Property(t => t.NewStaffingScheduleID).HasColumnName("NewStaffingScheduleID");
            this.Property(t => t.NewJobID).HasColumnName("NewJobID");
            this.Property(t => t.NewActivityGroupID).HasColumnName("NewActivityGroupID");
            this.Property(t => t.NewIsActive).HasColumnName("NewIsActive");
            this.Property(t => t.MassActionID).HasColumnName("MassActionID");
            this.Property(t => t.AssignmentHistoryDate).HasColumnName("AssignmentHistoryDate");
        }
    }
}
