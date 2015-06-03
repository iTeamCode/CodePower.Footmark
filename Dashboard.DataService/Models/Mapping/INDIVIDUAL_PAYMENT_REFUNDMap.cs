using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_PAYMENT_REFUNDMap : EntityTypeConfiguration<INDIVIDUAL_PAYMENT_REFUND>
    {
        public INDIVIDUAL_PAYMENT_REFUNDMap()
        {
            // Primary Key
            this.HasKey(t => t.INDIVIDUAL_PAYMENT_REFUND_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_PAYMENT_REFUND");
            this.Property(t => t.INDIVIDUAL_PAYMENT_REFUND_ID).HasColumnName("INDIVIDUAL_PAYMENT_REFUND_ID");
            this.Property(t => t.CC_ID).HasColumnName("CC_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.REGISTRATION_INSTANCE_ID).HasColumnName("REGISTRATION_INSTANCE_ID");
            this.Property(t => t.REFUND_AMOUNT).HasColumnName("REFUND_AMOUNT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.COMMONCC)
                .WithMany(t => t.INDIVIDUAL_PAYMENT_REFUND)
                .HasForeignKey(d => d.CC_ID);
            this.HasRequired(t => t.REGISTRATION_INSTANCE)
                .WithMany(t => t.INDIVIDUAL_PAYMENT_REFUND)
                .HasForeignKey(d => d.REGISTRATION_INSTANCE_ID);

        }
    }
}
