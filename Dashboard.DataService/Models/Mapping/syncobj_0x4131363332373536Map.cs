using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4131363332373536Map : EntityTypeConfiguration<syncobj_0x4131363332373536>
    {
        public syncobj_0x4131363332373536Map()
        {
            // Primary Key
            this.HasKey(t => new { t.PAY_LINE_ITEM_ID, t.CHURCH_ID, t.PAY_ORDER_ID, t.PAY_PRICING_ITEM_ID, t.LINE_ITEM_NAME, t.UNADJUSTED_AMOUNT, t.TOTAL_AMOUNT, t.IS_DELETED });

            // Properties
            this.Property(t => t.PAY_LINE_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAY_ORDER_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAY_PRICING_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LINE_ITEM_NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LINE_ITEM_DESCRIPTION)
                .HasMaxLength(100);

            this.Property(t => t.UNADJUSTED_AMOUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TOTAL_AMOUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4131363332373536");
            this.Property(t => t.PAY_LINE_ITEM_ID).HasColumnName("PAY_LINE_ITEM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.PAY_ORDER_ID).HasColumnName("PAY_ORDER_ID");
            this.Property(t => t.PAY_PRICING_ITEM_ID).HasColumnName("PAY_PRICING_ITEM_ID");
            this.Property(t => t.LINE_ITEM_NAME).HasColumnName("LINE_ITEM_NAME");
            this.Property(t => t.LINE_ITEM_DESCRIPTION).HasColumnName("LINE_ITEM_DESCRIPTION");
            this.Property(t => t.UNADJUSTED_AMOUNT).HasColumnName("UNADJUSTED_AMOUNT");
            this.Property(t => t.TOTAL_AMOUNT).HasColumnName("TOTAL_AMOUNT");
            this.Property(t => t.IS_DELETED).HasColumnName("IS_DELETED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
