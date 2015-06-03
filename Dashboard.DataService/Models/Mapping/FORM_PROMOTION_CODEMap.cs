using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_PROMOTION_CODEMap : EntityTypeConfiguration<FORM_PROMOTION_CODE>
    {
        public FORM_PROMOTION_CODEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FORM_ID, t.PAY_PRICING_ADJUSTMENT_ID });

            // Properties
            this.Property(t => t.FORM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAY_PRICING_ADJUSTMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_PROMOTION_CODE");
            this.Property(t => t.FORM_ID).HasColumnName("FORM_ID");
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_ID).HasColumnName("PAY_PRICING_ADJUSTMENT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.FORM)
                .WithMany(t => t.FORM_PROMOTION_CODE)
                .HasForeignKey(d => d.FORM_ID);
            this.HasRequired(t => t.PAY_PROMOTION_CODE)
                .WithMany(t => t.FORM_PROMOTION_CODE)
                .HasForeignKey(d => d.PAY_PRICING_ADJUSTMENT_ID);

        }
    }
}
