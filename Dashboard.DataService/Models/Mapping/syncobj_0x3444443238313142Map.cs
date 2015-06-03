using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3444443238313142Map : EntityTypeConfiguration<syncobj_0x3444443238313142>
    {
        public syncobj_0x3444443238313142Map()
        {
            // Primary Key
            this.HasKey(t => new { t.INDIVIDUAL_PAYMENT_ID, t.CHURCH_ID, t.INDIVIDUAL_REGISTRATION_ID, t.REGISTRATION_INSTANCE_PAYMENT_ID, t.PAYMENT_AMOUNT, t.ITEMS_AMOUNT });

            // Properties
            this.Property(t => t.INDIVIDUAL_PAYMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_INSTANCE_PAYMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAYMENT_AMOUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ITEMS_AMOUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3444443238313142");
            this.Property(t => t.INDIVIDUAL_PAYMENT_ID).HasColumnName("INDIVIDUAL_PAYMENT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID).HasColumnName("INDIVIDUAL_REGISTRATION_ID");
            this.Property(t => t.REGISTRATION_INSTANCE_PAYMENT_ID).HasColumnName("REGISTRATION_INSTANCE_PAYMENT_ID");
            this.Property(t => t.REGISTRATION_PAYMENT_ID).HasColumnName("REGISTRATION_PAYMENT_ID");
            this.Property(t => t.PAYMENT_AMOUNT).HasColumnName("PAYMENT_AMOUNT");
            this.Property(t => t.ITEMS_AMOUNT).HasColumnName("ITEMS_AMOUNT");
            this.Property(t => t.PROMOTION_CODE_ID).HasColumnName("PROMOTION_CODE_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
