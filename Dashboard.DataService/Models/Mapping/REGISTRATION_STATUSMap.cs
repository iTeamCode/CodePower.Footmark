using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_STATUSMap : EntityTypeConfiguration<REGISTRATION_STATUS>
    {
        public REGISTRATION_STATUSMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_STATUS_ID);

            // Properties
            this.Property(t => t.REGISTRATION_STATUS_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_STATUS");
            this.Property(t => t.REGISTRATION_STATUS_ID).HasColumnName("REGISTRATION_STATUS_ID");
            this.Property(t => t.REGISTRATION_STATUS_NAME).HasColumnName("REGISTRATION_STATUS_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
