using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3434443233344334Map : EntityTypeConfiguration<syncobj_0x3434443233344334>
    {
        public syncobj_0x3434443233344334Map()
        {
            // Primary Key
            this.HasKey(t => new { t.PAY_PAYMENT_ID, t.CHURCH_ID, t.PAY_TRANSACTION_ID, t.AMOUNT, t.PAYMENT_DATE });

            // Properties
            this.Property(t => t.PAY_PAYMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAY_TRANSACTION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AMOUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MEMO)
                .HasMaxLength(300);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3434443233344334");
            this.Property(t => t.PAY_PAYMENT_ID).HasColumnName("PAY_PAYMENT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.PAY_TRANSACTION_ID).HasColumnName("PAY_TRANSACTION_ID");
            this.Property(t => t.PAY_LINE_ITEM_ID).HasColumnName("PAY_LINE_ITEM_ID");
            this.Property(t => t.PAY_ORDER_ID).HasColumnName("PAY_ORDER_ID");
            this.Property(t => t.PAY_ORDER_SET_ID).HasColumnName("PAY_ORDER_SET_ID");
            this.Property(t => t.AMOUNT).HasColumnName("AMOUNT");
            this.Property(t => t.PAYMENT_DATE).HasColumnName("PAYMENT_DATE");
            this.Property(t => t.MEMO).HasColumnName("MEMO");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
