using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class JOB_MARITAL_STATUSMap : EntityTypeConfiguration<JOB_MARITAL_STATUS>
    {
        public JOB_MARITAL_STATUSMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JOB_ID, t.MARITAL_STATUS });

            // Properties
            this.Property(t => t.JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MARITAL_STATUS)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CREATED_BY_LOGIN)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.JOB_MARITAL_STATUS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("JOB_MARITAL_STATUS");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.MARITAL_STATUS).HasColumnName("MARITAL_STATUS");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_USER_ID).HasColumnName("LAST_UPDATED_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.JOB_MARITAL_STATUS_ID).HasColumnName("JOB_MARITAL_STATUS_ID");

            // Relationships
            this.HasRequired(t => t.JOB)
                .WithMany(t => t.JOB_MARITAL_STATUS)
                .HasForeignKey(d => d.JOB_ID);

        }
    }
}
