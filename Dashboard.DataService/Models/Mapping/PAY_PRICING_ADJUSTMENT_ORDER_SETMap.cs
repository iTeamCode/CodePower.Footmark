using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class PAY_PRICING_ADJUSTMENT_ORDER_SETMap : EntityTypeConfiguration<PAY_PRICING_ADJUSTMENT_ORDER_SET>
    {
        public PAY_PRICING_ADJUSTMENT_ORDER_SETMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PAY_PRICING_ADJUSTMENT_ID, t.PAY_ORDER_SET_ID });

            // Properties
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAY_ORDER_SET_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PAY_PRICING_ADJUSTMENT_ORDER_SET");
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_ID).HasColumnName("PAY_PRICING_ADJUSTMENT_ID");
            this.Property(t => t.PAY_ORDER_SET_ID).HasColumnName("PAY_ORDER_SET_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.PAY_ORDER_SET)
                .WithMany(t => t.PAY_PRICING_ADJUSTMENT_ORDER_SET)
                .HasForeignKey(d => d.PAY_ORDER_SET_ID);
            this.HasRequired(t => t.PAY_PRICING_ADJUSTMENT)
                .WithMany(t => t.PAY_PRICING_ADJUSTMENT_ORDER_SET)
                .HasForeignKey(d => d.PAY_PRICING_ADJUSTMENT_ID);

        }
    }
}
