using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3446333441413636Map : EntityTypeConfiguration<syncobj_0x3446333441413636>
    {
        public syncobj_0x3446333441413636Map()
        {
            // Primary Key
            this.HasKey(t => new { t.STAFFING_SCHEDULE_ID, t.CHURCH_ID, t.ACTIVITY_ID, t.STAFFING_SCHEDULE_NAME });

            // Properties
            this.Property(t => t.STAFFING_SCHEDULE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STAFFING_SCHEDULE_NAME)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3446333441413636");
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
        }
    }
}
