using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_INSTANCE_COUNTS_VMap : EntityTypeConfiguration<INDIVIDUAL_INSTANCE_COUNTS_V>
    {
        public INDIVIDUAL_INSTANCE_COUNTS_VMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_INSTANCE_ID, t.ACTIVITY_DETAIL_ID, t.ACTIVE_CHECKIN_ID });

            // Properties
            this.Property(t => t.ACTIVITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVE_CHECKIN_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_INSTANCE_COUNTS_V");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.ACTIVE_CHECKIN_ID).HasColumnName("ACTIVE_CHECKIN_ID");
            this.Property(t => t.PARTICIPANTS).HasColumnName("PARTICIPANTS");
            this.Property(t => t.VOLUNTEERS).HasColumnName("VOLUNTEERS");
        }
    }
}
