using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class PAY_PRICING_ITEMMap : EntityTypeConfiguration<PAY_PRICING_ITEM>
    {
        public PAY_PRICING_ITEMMap()
        {
            // Primary Key
            this.HasKey(t => t.PAY_PRICING_ITEM_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PAY_PRICING_ITEM");
            this.Property(t => t.PAY_PRICING_ITEM_ID).HasColumnName("PAY_PRICING_ITEM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.PRICE).HasColumnName("PRICE");
            this.Property(t => t.START_DATE).HasColumnName("START_DATE");
            this.Property(t => t.END_DATE).HasColumnName("END_DATE");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.IS_DEFAULT).HasColumnName("IS_DEFAULT");
            this.Property(t => t.PAY_ITEM_ID).HasColumnName("PAY_ITEM_ID");

            // Relationships
            this.HasRequired(t => t.PAY_ITEM)
                .WithMany(t => t.PAY_PRICING_ITEM)
                .HasForeignKey(d => d.PAY_ITEM_ID);

        }
    }
}
