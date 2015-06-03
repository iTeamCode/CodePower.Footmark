using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ATTENDANCE_HISTORY_VIEWMap : EntityTypeConfiguration<ATTENDANCE_HISTORY_VIEW>
    {
        public ATTENDANCE_HISTORY_VIEWMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CHURCH_ID, t.MINISTRY_ID, t.MINISTRY_NAME, t.ACTIVITY_ID, t.ACTIVITY_NAME, t.ROOM_LOCATION_CLASS_ID, t.ROOM_LOCATION_CLASS_NAME, t.ACTIVITY_GROUP_NAME, t.ACTIVITY_TIME_ID, t.ACTIVITY_INSTANCE_ID, t.START_DATE_TIME, t.STAFF_COUNT, t.PARTICIPANT_COUNT });

            // Properties
            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MINISTRY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MINISTRY_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ROOM_LOCATION_CLASS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ROOM_LOCATION_CLASS_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ACTIVITY_GROUP_NAME)
                .IsRequired()
                .HasMaxLength(96);

            this.Property(t => t.ACTIVITY_TIME_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_TIME_NAME)
                .HasMaxLength(30);

            this.Property(t => t.ACTIVITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STAFF_COUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PARTICIPANT_COUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ATTENDANCE_HISTORY_VIEW");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.MINISTRY_ID).HasColumnName("MINISTRY_ID");
            this.Property(t => t.MINISTRY_NAME).HasColumnName("MINISTRY_NAME");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_NAME).HasColumnName("ACTIVITY_NAME");
            this.Property(t => t.ROOM_LOCATION_CLASS_ID).HasColumnName("ROOM_LOCATION_CLASS_ID");
            this.Property(t => t.ROOM_LOCATION_CLASS_NAME).HasColumnName("ROOM_LOCATION_CLASS_NAME");
            this.Property(t => t.ACTIVITY_GROUP_NAME).HasColumnName("ACTIVITY_GROUP_NAME");
            this.Property(t => t.ACTIVITY_GROUP_ID).HasColumnName("ACTIVITY_GROUP_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.ACTIVITY_TIME_NAME).HasColumnName("ACTIVITY_TIME_NAME");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.START_DATE_TIME).HasColumnName("START_DATE_TIME");
            this.Property(t => t.STAFF_COUNT).HasColumnName("STAFF_COUNT");
            this.Property(t => t.PARTICIPANT_COUNT).HasColumnName("PARTICIPANT_COUNT");
        }
    }
}
