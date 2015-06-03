using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_INSTANCE_PAYMENTMap : EntityTypeConfiguration<REGISTRATION_INSTANCE_PAYMENT>
    {
        public REGISTRATION_INSTANCE_PAYMENTMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_INSTANCE_PAYMENT_ID);

            // Properties
            this.Property(t => t.REFERENCE)
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_INSTANCE_PAYMENT");
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

            // Relationships
            this.HasOptional(t => t.COMMONCC)
                .WithMany(t => t.REGISTRATION_INSTANCE_PAYMENT)
                .HasForeignKey(d => d.CC_ID);
            this.HasOptional(t => t.PROMOTION_CODE)
                .WithMany(t => t.REGISTRATION_INSTANCE_PAYMENT)
                .HasForeignKey(d => d.PROMOTION_CODE_ID);
            this.HasRequired(t => t.REGISTRATION_INSTANCE)
                .WithMany(t => t.REGISTRATION_INSTANCE_PAYMENT)
                .HasForeignKey(d => d.REGISTRATION_INSTANCE_ID);
            this.HasRequired(t => t.REGISTRATION_PAYMENT_TYPE)
                .WithMany(t => t.REGISTRATION_INSTANCE_PAYMENT)
                .HasForeignKey(d => d.PAYMENT_TYPE_ID);

        }
    }
}
