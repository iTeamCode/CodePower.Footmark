using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REFERENCE_INSTANCEMap : EntityTypeConfiguration<REFERENCE_INSTANCE>
    {
        public REFERENCE_INSTANCEMap()
        {
            // Primary Key
            this.HasKey(t => t.REFERENCE_INSTANCE_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REFERENCE_INSTANCE");
            this.Property(t => t.REFERENCE_INSTANCE_ID).HasColumnName("REFERENCE_INSTANCE_ID");
            this.Property(t => t.REFERENCE_ID).HasColumnName("REFERENCE_ID");
            this.Property(t => t.USER_ID).HasColumnName("USER_ID");
            this.Property(t => t.CREATED_DATETIME).HasColumnName("CREATED_DATETIME");
            this.Property(t => t.IS_COMPLETE).HasColumnName("IS_COMPLETE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.REFERENCE)
                .WithMany(t => t.REFERENCE_INSTANCE)
                .HasForeignKey(d => d.REFERENCE_ID);

        }
    }
}
