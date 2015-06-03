using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVE_DETAIL_CHECKINMap : EntityTypeConfiguration<ACTIVE_DETAIL_CHECKIN>
    {
        public ACTIVE_DETAIL_CHECKINMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_DETAIL_ID, t.ACTIVE_CHECKIN_ID });

            // Properties
            this.Property(t => t.ACTIVITY_DETAIL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVE_CHECKIN_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVE_DETAIL_CHECKIN");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.ACTIVE_CHECKIN_ID).HasColumnName("ACTIVE_CHECKIN_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.IS_OPEN).HasColumnName("IS_OPEN");
            this.Property(t => t.CAPACITY).HasColumnName("CAPACITY");
            this.Property(t => t.VOLUNTEER_COUNT).HasColumnName("VOLUNTEER_COUNT");
            this.Property(t => t.HOLDOVER_COUNT).HasColumnName("HOLDOVER_COUNT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVE_CHECKIN)
                .WithMany(t => t.ACTIVE_DETAIL_CHECKIN)
                .HasForeignKey(d => d.ACTIVE_CHECKIN_ID);
            this.HasRequired(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.ACTIVE_DETAIL_CHECKIN)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);

        }
    }
}
