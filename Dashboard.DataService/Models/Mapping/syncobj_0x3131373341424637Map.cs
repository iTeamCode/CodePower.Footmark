using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3131373341424637Map : EntityTypeConfiguration<syncobj_0x3131373341424637>
    {
        public syncobj_0x3131373341424637Map()
        {
            // Primary Key
            this.HasKey(t => new { t.CHECK_IN_MACHINE_ID, t.CHURCH_ID, t.INSTALL_CODE, t.MACHINE_NAME });

            // Properties
            this.Property(t => t.CHECK_IN_MACHINE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INSTALL_CODE)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MACHINE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.APP_VERSION)
                .HasMaxLength(10);

            this.Property(t => t.OS_VERSION)
                .HasMaxLength(50);

            this.Property(t => t.CLR_VERSION)
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3131373341424637");
            this.Property(t => t.CHECK_IN_MACHINE_ID).HasColumnName("CHECK_IN_MACHINE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INSTALL_CODE).HasColumnName("INSTALL_CODE");
            this.Property(t => t.MACHINE_NAME).HasColumnName("MACHINE_NAME");
            this.Property(t => t.APP_VERSION).HasColumnName("APP_VERSION");
            this.Property(t => t.LAST_UPDATE).HasColumnName("LAST_UPDATE");
            this.Property(t => t.OS_VERSION).HasColumnName("OS_VERSION");
            this.Property(t => t.CLR_VERSION).HasColumnName("CLR_VERSION");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
