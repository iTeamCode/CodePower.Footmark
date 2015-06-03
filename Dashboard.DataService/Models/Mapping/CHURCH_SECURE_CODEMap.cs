using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class CHURCH_SECURE_CODEMap : EntityTypeConfiguration<CHURCH_SECURE_CODE>
    {
        public CHURCH_SECURE_CODEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SECURE_CODE_ID, t.CHURCH_ID });

            // Properties
            this.Property(t => t.SECURE_CODE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CHURCH_SECURE_CODE");
            this.Property(t => t.SECURE_CODE_ID).HasColumnName("SECURE_CODE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.SECURE_CODE)
                .WithMany(t => t.CHURCH_SECURE_CODE)
                .HasForeignKey(d => d.SECURE_CODE_ID);

        }
    }
}
