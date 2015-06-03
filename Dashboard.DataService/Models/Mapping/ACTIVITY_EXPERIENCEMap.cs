using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_EXPERIENCEMap : EntityTypeConfiguration<ACTIVITY_EXPERIENCE>
    {
        public ACTIVITY_EXPERIENCEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_ID, t.EXPERIENCE_TYPE_ID });

            // Properties
            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EXPERIENCE_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_EXPERIENCE");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.EXPERIENCE_TYPE_ID).HasColumnName("EXPERIENCE_TYPE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.IS_VOLUNTEER).HasColumnName("IS_VOLUNTEER");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.ACTIVITY_EXPERIENCE)
                .HasForeignKey(d => d.ACTIVITY_ID);

        }
    }
}
