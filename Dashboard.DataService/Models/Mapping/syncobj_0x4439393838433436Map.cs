using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4439393838433436Map : EntityTypeConfiguration<syncobj_0x4439393838433436>
    {
        public syncobj_0x4439393838433436Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REGISTRATION_INSTANCE_ID, t.CHURCH_ID, t.ACTIVITY_REGISTRATION_ID, t.INDIVIDUAL_ID, t.CREATED });

            // Properties
            this.Property(t => t.REGISTRATION_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_REGISTRATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EMAIL)
                .HasMaxLength(100);

            this.Property(t => t.CONFIRMATION_CODE)
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4439393838433436");
            this.Property(t => t.REGISTRATION_INSTANCE_ID).HasColumnName("REGISTRATION_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.CONFIRMATION_CODE).HasColumnName("CONFIRMATION_CODE");
            this.Property(t => t.CREATED).HasColumnName("CREATED");
            this.Property(t => t.MODIFIED).HasColumnName("MODIFIED");
            this.Property(t => t.COMPANY_ID).HasColumnName("COMPANY_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_PARENT_ID).HasColumnName("ACTIVITY_REGISTRATION_PARENT_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
