using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class STAFFING_SCHEDULE_INSTANCEMap : EntityTypeConfiguration<STAFFING_SCHEDULE_INSTANCE>
    {
        public STAFFING_SCHEDULE_INSTANCEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.individual_id, t.individual_type_id, t.activity_id, t.activity_time_id, t.activity_instance_id, t.start_date_time, t.church_id, t.staffing_schedule_id });

            // Properties
            this.Property(t => t.individual_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.individual_type_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.activity_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.activity_time_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.activity_instance_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.end_date_time)
                .HasMaxLength(61);

            this.Property(t => t.church_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.staffing_schedule_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("STAFFING_SCHEDULE_INSTANCE");
            this.Property(t => t.individual_id).HasColumnName("individual_id");
            this.Property(t => t.individual_type_id).HasColumnName("individual_type_id");
            this.Property(t => t.activity_id).HasColumnName("activity_id");
            this.Property(t => t.activity_time_id).HasColumnName("activity_time_id");
            this.Property(t => t.activity_instance_id).HasColumnName("activity_instance_id");
            this.Property(t => t.start_date_time).HasColumnName("start_date_time");
            this.Property(t => t.end_date_time).HasColumnName("end_date_time");
            this.Property(t => t.activity_detail_id).HasColumnName("activity_detail_id");
            this.Property(t => t.job_id).HasColumnName("job_id");
            this.Property(t => t.church_id).HasColumnName("church_id");
            this.Property(t => t.staffing_schedule_id).HasColumnName("staffing_schedule_id");
        }
    }
}
