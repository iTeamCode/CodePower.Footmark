using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3837363943313431Map : EntityTypeConfiguration<syncobj_0x3837363943313431>
    {
        public syncobj_0x3837363943313431Map()
        {
            // Primary Key
            this.HasKey(t => new { t.PAY_PAYMENT_REQUIREMENT_ID, t.PAY_PAYMENT_REQUIREMENT_TYPE_ID, t.PAY_ITEM_ID, t.CHURCH_ID });

            // Properties
            this.Property(t => t.PAY_PAYMENT_REQUIREMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PAY_PAYMENT_REQUIREMENT_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAY_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3837363943313431");
            this.Property(t => t.PAY_PAYMENT_REQUIREMENT_ID).HasColumnName("PAY_PAYMENT_REQUIREMENT_ID");
            this.Property(t => t.PAY_PAYMENT_REQUIREMENT_TYPE_ID).HasColumnName("PAY_PAYMENT_REQUIREMENT_TYPE_ID");
            this.Property(t => t.PAY_ITEM_ID).HasColumnName("PAY_ITEM_ID");
            this.Property(t => t.AMOUNT).HasColumnName("AMOUNT");
            this.Property(t => t.PERCENTAGE).HasColumnName("PERCENTAGE");
            this.Property(t => t.REQUIRED_DATE).HasColumnName("REQUIRED_DATE");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
