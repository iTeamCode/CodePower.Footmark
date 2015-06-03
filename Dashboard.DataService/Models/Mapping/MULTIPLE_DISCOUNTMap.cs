using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class MULTIPLE_DISCOUNTMap : EntityTypeConfiguration<MULTIPLE_DISCOUNT>
    {
        public MULTIPLE_DISCOUNTMap()
        {
            // Primary Key
            this.HasKey(t => t.MULTIPLE_DISCOUNT_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("MULTIPLE_DISCOUNT");
            this.Property(t => t.MULTIPLE_DISCOUNT_ID).HasColumnName("MULTIPLE_DISCOUNT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.MINIMUM_REGISTRATIONS).HasColumnName("MINIMUM_REGISTRATIONS");
            this.Property(t => t.DISCOUNT_AMOUNT).HasColumnName("DISCOUNT_AMOUNT");
            this.Property(t => t.START_DATE).HasColumnName("START_DATE");
            this.Property(t => t.END_DATE).HasColumnName("END_DATE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_REGISTRATION)
                .WithMany(t => t.MULTIPLE_DISCOUNT)
                .HasForeignKey(d => d.ACTIVITY_REGISTRATION_ID);

        }
    }
}
