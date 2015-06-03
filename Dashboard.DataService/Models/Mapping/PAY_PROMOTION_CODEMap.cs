using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class PAY_PROMOTION_CODEMap : EntityTypeConfiguration<PAY_PROMOTION_CODE>
    {
        public PAY_PROMOTION_CODEMap()
        {
            // Primary Key
            this.HasKey(t => t.PAY_PRICING_ADJUSTMENT_ID);

            // Properties
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PROMOTION_CODE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PROMOTION_CODE_CODE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PAY_PROMOTION_CODE");
            this.Property(t => t.PAY_PRICING_ADJUSTMENT_ID).HasColumnName("PAY_PRICING_ADJUSTMENT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.PROMOTION_CODE_NAME).HasColumnName("PROMOTION_CODE_NAME");
            this.Property(t => t.PROMOTION_CODE_CODE).HasColumnName("PROMOTION_CODE_CODE");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.TOTAL_USES).HasColumnName("TOTAL_USES");
            this.Property(t => t.USES_LEFT).HasColumnName("USES_LEFT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.PAY_PRICING_ADJUSTMENT)
                .WithOptional(t => t.PAY_PROMOTION_CODE);

        }
    }
}
