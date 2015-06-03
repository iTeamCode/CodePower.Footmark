using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_PAYMENT_2Map : EntityTypeConfiguration<REGISTRATION_PAYMENT_2>
    {
        public REGISTRATION_PAYMENT_2Map()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_PAYMENT_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_PAYMENT_2");
            this.Property(t => t.REGISTRATION_PAYMENT_ID).HasColumnName("REGISTRATION_PAYMENT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.START_DATE).HasColumnName("START_DATE");
            this.Property(t => t.END_DATE).HasColumnName("END_DATE");
            this.Property(t => t.PAYMENT_AMOUNT).HasColumnName("PAYMENT_AMOUNT");
            this.Property(t => t.DOWNPAYMENT_ALLOWED).HasColumnName("DOWNPAYMENT_ALLOWED");
            this.Property(t => t.DOWNPAYMENT_AMOUNT).HasColumnName("DOWNPAYMENT_AMOUNT");
            this.Property(t => t.FULL_PAYMENT_DATE).HasColumnName("FULL_PAYMENT_DATE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_REGISTRATION)
                .WithMany(t => t.REGISTRATION_PAYMENT_2)
                .HasForeignKey(d => d.ACTIVITY_REGISTRATION_ID);

        }
    }
}
