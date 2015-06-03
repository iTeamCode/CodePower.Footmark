using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_INSTANCEMap : EntityTypeConfiguration<ACTIVITY_INSTANCE>
    {
        public ACTIVITY_INSTANCEMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_INSTANCE_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_INSTANCE");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.START_DATE_TIME).HasColumnName("START_DATE_TIME");
            this.Property(t => t.START_CHECKIN).HasColumnName("START_CHECKIN");
            this.Property(t => t.END_CHECKIN).HasColumnName("END_CHECKIN");
            this.Property(t => t.ACTIVITY_SERIES_ID).HasColumnName("ACTIVITY_SERIES_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.OLD_ACT_INS_ID).HasColumnName("OLD_ACT_INS_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.ACTIVITY_INSTANCE)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasOptional(t => t.ACTIVITY_SERIES)
                .WithMany(t => t.ACTIVITY_INSTANCE)
                .HasForeignKey(d => d.ACTIVITY_SERIES_ID);

        }
    }
}
