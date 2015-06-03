using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class vw_MismatchedActivityTimesMap : EntityTypeConfiguration<vw_MismatchedActivityTimes>
    {
        public vw_MismatchedActivityTimesMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_TIME_ID, t.ACTIVITY_INSTANCE_ID, t.CHURCH_ID, t.ACTIVITY_ID, t.ACTIVITY_START_TIME, t.START_DATE_TIME });

            // Properties
            this.Property(t => t.ACTIVITY_TIME_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_TIME_NAME)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("vw_MismatchedActivityTimes");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_TIME_NAME).HasColumnName("ACTIVITY_TIME_NAME");
            this.Property(t => t.ACTIVITY_START_TIME).HasColumnName("ACTIVITY_START_TIME");
            this.Property(t => t.ACTIVITY_END_TIME).HasColumnName("ACTIVITY_END_TIME");
            this.Property(t => t.START_DATE_TIME).HasColumnName("START_DATE_TIME");
            this.Property(t => t.START_CHECKIN).HasColumnName("START_CHECKIN");
            this.Property(t => t.END_CHECKIN).HasColumnName("END_CHECKIN");
        }
    }
}
