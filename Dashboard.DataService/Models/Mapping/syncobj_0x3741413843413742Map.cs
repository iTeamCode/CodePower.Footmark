using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3741413843413742Map : EntityTypeConfiguration<syncobj_0x3741413843413742>
    {
        public syncobj_0x3741413843413742Map()
        {
            // Primary Key
            this.HasKey(t => new { t.PAY_PRICING_ADJUSTMENT_ID, t.PAY_PRICING_ADJUSTMENT_TYPE_ID, t.CHURCH_ID });

            // Properties
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PAY_PRICING_ADJUSTMENT_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.MEMO)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3741413843413742");
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_ID).HasColumnName("PAY_PRICING_ADJUSTMENT_ID");
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_TYPE_ID).HasColumnName("PAY_PRICING_ADJUSTMENT_TYPE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.AMOUNT).HasColumnName("AMOUNT");
            this.Property(t => t.PERCENTAGE).HasColumnName("PERCENTAGE");
            this.Property(t => t.START_DATE).HasColumnName("START_DATE");
            this.Property(t => t.END_DATE).HasColumnName("END_DATE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.MEMO).HasColumnName("MEMO");
        }
    }
}
