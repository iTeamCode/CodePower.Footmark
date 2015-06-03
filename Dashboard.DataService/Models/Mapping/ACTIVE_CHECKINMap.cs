using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVE_CHECKINMap : EntityTypeConfiguration<ACTIVE_CHECKIN>
    {
        public ACTIVE_CHECKINMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVE_CHECKIN_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVE_CHECKIN");
            this.Property(t => t.ACTIVE_CHECKIN_ID).HasColumnName("ACTIVE_CHECKIN_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_INSTANCE)
                .WithMany(t => t.ACTIVE_CHECKIN)
                .HasForeignKey(d => d.ACTIVITY_INSTANCE_ID);

        }
    }
}
