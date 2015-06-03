using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_INSTANCE_HISTORY_VMap : EntityTypeConfiguration<INDIVIDUAL_INSTANCE_HISTORY_V>
    {
        public INDIVIDUAL_INSTANCE_HISTORY_VMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CHURCH_ID, t.INDIVIDUAL_TYPE_ID, t.INDIVIDUAL_TYPE_NAME, t.MINISTRY_ID, t.MINISTRY_NAME, t.ACTIVITY_ID, t.ACTIVITY_NAME, t.ACTIVITY_INSTANCE_ID, t.START_DATE_TIME, t.ACTIVITY_DETAIL_ID, t.ACTIVITY_DETAIL_NAME, t.INDIVIDUAL_INSTANCE_ID });

            // Properties
            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_TYPE_NAME)
                .IsRequired()
                .HasMaxLength(20);

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

            this.Property(t => t.ACTIVITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.INDIVIDUAL_GROUP_NAME)
                .HasMaxLength(20);

            this.Property(t => t.INDIVIDUAL_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_INSTANCE_HISTORY_V");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INDIVIDUAL_TYPE_ID).HasColumnName("INDIVIDUAL_TYPE_ID");
            this.Property(t => t.INDIVIDUAL_TYPE_NAME).HasColumnName("INDIVIDUAL_TYPE_NAME");
            this.Property(t => t.MINISTRY_ID).HasColumnName("MINISTRY_ID");
            this.Property(t => t.MINISTRY_NAME).HasColumnName("MINISTRY_NAME");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_NAME).HasColumnName("ACTIVITY_NAME");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.START_DATE_TIME).HasColumnName("START_DATE_TIME");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.ACTIVITY_DETAIL_NAME).HasColumnName("ACTIVITY_DETAIL_NAME");
            this.Property(t => t.INDIVIDUAL_GROUP_ID).HasColumnName("INDIVIDUAL_GROUP_ID");
            this.Property(t => t.INDIVIDUAL_GROUP_NAME).HasColumnName("INDIVIDUAL_GROUP_NAME");
            this.Property(t => t.INDIVIDUAL_INSTANCE_ID).HasColumnName("INDIVIDUAL_INSTANCE_ID");
        }
    }
}
