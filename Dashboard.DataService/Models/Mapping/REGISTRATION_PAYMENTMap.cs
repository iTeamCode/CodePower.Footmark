using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_PAYMENTMap : EntityTypeConfiguration<REGISTRATION_PAYMENT>
    {
        public REGISTRATION_PAYMENTMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_PAYMENT_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_PAYMENT");
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

            // Relationships
            this.HasRequired(t => t.REGISTRATION_PAYMENT_OPTION)
                .WithMany(t => t.REGISTRATION_PAYMENT)
                .HasForeignKey(d => d.REGISTRATION_PAYMENT_OPTION_ID);
            this.HasRequired(t => t.REGISTRATION_PAYMENT_TYPE)
                .WithMany(t => t.REGISTRATION_PAYMENT)
                .HasForeignKey(d => d.PAYMENT_TYPE_ID);

        }
    }
}
