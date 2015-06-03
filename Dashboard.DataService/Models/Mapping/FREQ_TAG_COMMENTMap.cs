using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FREQ_TAG_COMMENTMap : EntityTypeConfiguration<FREQ_TAG_COMMENT>
    {
        public FREQ_TAG_COMMENTMap()
        {
            // Primary Key
            this.HasKey(t => t.FREQ_COMMENT_ID);

            // Properties
            this.Property(t => t.TAG_COMMENT)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TAG_COMMENT_ABBREVIATION)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FREQ_TAG_COMMENT");
            this.Property(t => t.FREQ_COMMENT_ID).HasColumnName("FREQ_COMMENT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.TAG_COMMENT).HasColumnName("TAG_COMMENT");
            this.Property(t => t.TAG_COMMENT_ABBREVIATION).HasColumnName("TAG_COMMENT_ABBREVIATION");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.FREQ_TAG_COMMENT)
                .HasForeignKey(d => d.CHURCH_ID);

        }
    }
}
