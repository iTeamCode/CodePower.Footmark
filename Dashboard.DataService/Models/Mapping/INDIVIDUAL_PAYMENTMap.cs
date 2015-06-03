using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_PAYMENTMap : EntityTypeConfiguration<INDIVIDUAL_PAYMENT>
    {
        public INDIVIDUAL_PAYMENTMap()
        {
            // Primary Key
            this.HasKey(t => t.INDIVIDUAL_PAYMENT_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_PAYMENT");
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

            // Relationships
            this.HasRequired(t => t.INDIVIDUAL_REGISTRATION_2)
                .WithMany(t => t.INDIVIDUAL_PAYMENT)
                .HasForeignKey(d => d.INDIVIDUAL_REGISTRATION_ID);
            this.HasOptional(t => t.PROMOTION_CODE)
                .WithMany(t => t.INDIVIDUAL_PAYMENT)
                .HasForeignKey(d => d.PROMOTION_CODE_ID);
            this.HasRequired(t => t.REGISTRATION_INSTANCE_PAYMENT)
                .WithMany(t => t.INDIVIDUAL_PAYMENT)
                .HasForeignKey(d => d.REGISTRATION_INSTANCE_PAYMENT_ID);
            this.HasOptional(t => t.REGISTRATION_PAYMENT_2)
                .WithMany(t => t.INDIVIDUAL_PAYMENT)
                .HasForeignKey(d => d.REGISTRATION_PAYMENT_ID);

        }
    }
}
