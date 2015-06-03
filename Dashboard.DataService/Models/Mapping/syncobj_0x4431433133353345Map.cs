using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4431433133353345Map : EntityTypeConfiguration<syncobj_0x4431433133353345>
    {
        public syncobj_0x4431433133353345Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REGISTRATION_INSTANCE_PAYMENT_ID, t.CHURCH_ID, t.REGISTRATION_INSTANCE_ID, t.PAYMENT_DATE_TIME, t.PAYMENT_TYPE_ID, t.AMOUNT, t.PROCESSED });

            // Properties
            this.Property(t => t.REGISTRATION_INSTANCE_PAYMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAYMENT_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AMOUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REFERENCE)
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4431433133353345");
            this.Property(t => t.REGISTRATION_INSTANCE_PAYMENT_ID).HasColumnName("REGISTRATION_INSTANCE_PAYMENT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.REGISTRATION_INSTANCE_ID).HasColumnName("REGISTRATION_INSTANCE_ID");
            this.Property(t => t.PAYMENT_DATE_TIME).HasColumnName("PAYMENT_DATE_TIME");
            this.Property(t => t.PAYMENT_TYPE_ID).HasColumnName("PAYMENT_TYPE_ID");
            this.Property(t => t.CC_ID).HasColumnName("CC_ID");
            this.Property(t => t.AMOUNT).HasColumnName("AMOUNT");
            this.Property(t => t.PROMOTION_CODE_ID).HasColumnName("PROMOTION_CODE_ID");
            this.Property(t => t.PROCESSED).HasColumnName("PROCESSED");
            this.Property(t => t.REFERENCE).HasColumnName("REFERENCE");
            this.Property(t => t.CHECK_ID).HasColumnName("CHECK_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
