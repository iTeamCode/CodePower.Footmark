using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3939304446303644Map : EntityTypeConfiguration<syncobj_0x3939304446303644>
    {
        public syncobj_0x3939304446303644Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REGISTRATION_PAYMENT_ID, t.CHURCH_ID, t.REGISTRATION_PAYMENT_OPTION_ID, t.INDIVIDUAL_REGISTRATION_ID, t.PAYMENT_TYPE_ID, t.PROCESSED });

            // Properties
            this.Property(t => t.REGISTRATION_PAYMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_PAYMENT_OPTION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAYMENT_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3939304446303644");
            this.Property(t => t.REGISTRATION_PAYMENT_ID).HasColumnName("REGISTRATION_PAYMENT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.REGISTRATION_PAYMENT_OPTION_ID).HasColumnName("REGISTRATION_PAYMENT_OPTION_ID");
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID).HasColumnName("INDIVIDUAL_REGISTRATION_ID");
            this.Property(t => t.PAYMENT_DATE).HasColumnName("PAYMENT_DATE");
            this.Property(t => t.PAYMENT_TYPE_ID).HasColumnName("PAYMENT_TYPE_ID");
            this.Property(t => t.PAYMENT_AMOUNT).HasColumnName("PAYMENT_AMOUNT");
            this.Property(t => t.CC_ID).HasColumnName("CC_ID");
            this.Property(t => t.PROCESSED).HasColumnName("PROCESSED");
            this.Property(t => t.CHECK_NO).HasColumnName("CHECK_NO");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
