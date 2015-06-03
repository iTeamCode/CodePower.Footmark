using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class JOB_JOB_ATTRIBUTEMap : EntityTypeConfiguration<JOB_JOB_ATTRIBUTE>
    {
        public JOB_JOB_ATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JOB_ID, t.JOB_ATTRIBUTE_ID });

            // Properties
            this.Property(t => t.JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JOB_ATTRIBUTE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.JOB_JOB_ATTRIBUTE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("JOB_JOB_ATTRIBUTE");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.JOB_ATTRIBUTE_ID).HasColumnName("JOB_ATTRIBUTE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.JOB_JOB_ATTRIBUTE_ID).HasColumnName("JOB_JOB_ATTRIBUTE_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.JOB)
                .WithMany(t => t.JOB_JOB_ATTRIBUTE)
                .HasForeignKey(d => d.JOB_ID);
            this.HasRequired(t => t.JOB_ATTRIBUTE)
                .WithMany(t => t.JOB_JOB_ATTRIBUTE)
                .HasForeignKey(d => d.JOB_ATTRIBUTE_ID);

        }
    }
}
