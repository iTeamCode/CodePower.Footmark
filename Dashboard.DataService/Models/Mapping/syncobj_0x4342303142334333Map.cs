using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4342303142334333Map : EntityTypeConfiguration<syncobj_0x4342303142334333>
    {
        public syncobj_0x4342303142334333Map()
        {
            // Primary Key
            this.HasKey(t => new { t.PAY_PRICING_ADJUSTMENT_TYPE_ID, t.PRICING_ADJUSTMENT_TYPE_NAME });

            // Properties
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PRICING_ADJUSTMENT_TYPE_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4342303142334333");
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_TYPE_ID).HasColumnName("PAY_PRICING_ADJUSTMENT_TYPE_ID");
            this.Property(t => t.PRICING_ADJUSTMENT_TYPE_NAME).HasColumnName("PRICING_ADJUSTMENT_TYPE_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
