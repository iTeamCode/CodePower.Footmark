using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class GFT_JOB_CATEGORYMap : EntityTypeConfiguration<GFT_JOB_CATEGORY>
    {
        public GFT_JOB_CATEGORYMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GFT_JOB_ID, t.GFT_CATEGORY_ID });

            // Properties
            this.Property(t => t.GFT_JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GFT_CATEGORY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GFT_JOB_CATEGORY");
            this.Property(t => t.GFT_JOB_ID).HasColumnName("GFT_JOB_ID");
            this.Property(t => t.GFT_CATEGORY_ID).HasColumnName("GFT_CATEGORY_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CATEGORY_PERCENTAGE).HasColumnName("CATEGORY_PERCENTAGE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.GFT_JOB)
                .WithMany(t => t.GFT_JOB_CATEGORY)
                .HasForeignKey(d => d.GFT_JOB_ID);

        }
    }
}
