using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_PAYMENT_OPTIONMap : EntityTypeConfiguration<REGISTRATION_PAYMENT_OPTION>
    {
        public REGISTRATION_PAYMENT_OPTIONMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_PAYMENT_OPTION_ID);

            // Properties
            this.Property(t => t.PAYMENT_OPTION_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_PAYMENT_OPTION");
            this.Property(t => t.REGISTRATION_PAYMENT_OPTION_ID).HasColumnName("REGISTRATION_PAYMENT_OPTION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.PAYMENT_OPTION_NAME).HasColumnName("PAYMENT_OPTION_NAME");
            this.Property(t => t.PAYMENT_AMOUNT).HasColumnName("PAYMENT_AMOUNT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.REGISTRATION_PAYMENT_OPTION)
                .HasForeignKey(d => d.ACTIVITY_ID);

        }
    }
}
