using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_TAGMap : EntityTypeConfiguration<ACTIVITY_TAG>
    {
        public ACTIVITY_TAGMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TAG_TEMPLATE_ID, t.ACTIVITY_ID });

            // Properties
            this.Property(t => t.TAG_TEMPLATE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_TAG");
            this.Property(t => t.TAG_TEMPLATE_ID).HasColumnName("TAG_TEMPLATE_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.IS_RECEIPT).HasColumnName("IS_RECEIPT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.ACTIVITY_TAG)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasRequired(t => t.TAG_TEMPLATE)
                .WithMany(t => t.ACTIVITY_TAG)
                .HasForeignKey(d => d.TAG_TEMPLATE_ID);

        }
    }
}
