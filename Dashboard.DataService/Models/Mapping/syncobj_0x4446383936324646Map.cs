using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4446383936324646Map : EntityTypeConfiguration<syncobj_0x4446383936324646>
    {
        public syncobj_0x4446383936324646Map()
        {
            // Primary Key
            this.HasKey(t => new { t.OPTION_TABLE_ID, t.OPTION_TABLE_NAME });

            // Properties
            this.Property(t => t.OPTION_TABLE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.OPTION_TABLE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4446383936324646");
            this.Property(t => t.OPTION_TABLE_ID).HasColumnName("OPTION_TABLE_ID");
            this.Property(t => t.OPTION_TABLE_NAME).HasColumnName("OPTION_TABLE_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
