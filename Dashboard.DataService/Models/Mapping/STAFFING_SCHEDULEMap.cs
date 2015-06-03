using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class STAFFING_SCHEDULEMap : EntityTypeConfiguration<STAFFING_SCHEDULE>
    {
        public STAFFING_SCHEDULEMap()
        {
            // Primary Key
            this.HasKey(t => t.STAFFING_SCHEDULE_ID);

            // Properties
            this.Property(t => t.STAFFING_SCHEDULE_NAME)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("STAFFING_SCHEDULE");
            this.Property(t => t.STAFFING_SCHEDULE_ID).HasColumnName("STAFFING_SCHEDULE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.STAFFING_SCHEDULE_NAME).HasColumnName("STAFFING_SCHEDULE_NAME");
            this.Property(t => t.old_staff_sched_id).HasColumnName("old_staff_sched_id");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.STAFFING_SCHEDULE)
                .HasForeignKey(d => d.ACTIVITY_ID);

        }
    }
}
