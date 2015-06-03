using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class SECURE_CODEMap : EntityTypeConfiguration<SECURE_CODE>
    {
        public SECURE_CODEMap()
        {
            // Primary Key
            this.HasKey(t => t.SECURE_CODE_ID);

            // Properties
            this.Property(t => t.SECURE_CODE1)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SECURE_CODE");
            this.Property(t => t.SECURE_CODE_ID).HasColumnName("SECURE_CODE_ID");
            this.Property(t => t.SECURE_CODE1).HasColumnName("SECURE_CODE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
