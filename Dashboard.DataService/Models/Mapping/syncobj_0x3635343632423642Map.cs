using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3635343632423642Map : EntityTypeConfiguration<syncobj_0x3635343632423642>
    {
        public syncobj_0x3635343632423642Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REGISTRATION_STATUS_ID, t.REGISTRATION_STATUS_NAME });

            // Properties
            this.Property(t => t.REGISTRATION_STATUS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.REGISTRATION_STATUS_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3635343632423642");
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
