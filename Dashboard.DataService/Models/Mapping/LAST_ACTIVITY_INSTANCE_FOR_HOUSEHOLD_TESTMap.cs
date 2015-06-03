using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_TESTMap : EntityTypeConfiguration<LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_TEST>
    {
        public LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_TESTMap()
        {
            // Primary Key
            this.HasKey(t => new { t.HOUSEHOLD_ID, t.INDIVIDUAL_ID, t.CHURCH_ID });

            // Properties
            this.Property(t => t.HOUSEHOLD_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_NAME)
                .HasMaxLength(30);

            this.Property(t => t.ACTIVITY_NAME)
                .HasMaxLength(30);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("LAST_ACTIVITY_INSTANCE_FOR_HOUSEHOLD_TEST");
            this.Property(t => t.HOUSEHOLD_ID).HasColumnName("HOUSEHOLD_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.ACTIVITY_DETAIL_NAME).HasColumnName("ACTIVITY_DETAIL_NAME");
            this.Property(t => t.ACTIVITY_NAME).HasColumnName("ACTIVITY_NAME");
            this.Property(t => t.START_DATE_TIME).HasColumnName("START_DATE_TIME");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
        }
    }
}
