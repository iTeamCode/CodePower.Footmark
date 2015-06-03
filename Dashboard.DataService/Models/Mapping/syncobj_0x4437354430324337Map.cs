using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4437354430324337Map : EntityTypeConfiguration<syncobj_0x4437354430324337>
    {
        public syncobj_0x4437354430324337Map()
        {
            // Primary Key
            this.HasKey(t => new { t.INDIVIDUAL_REGISTRATION_ID, t.CHURCH_ID, t.ACTIVITY_ID, t.INDIVIDUAL_ID });

            // Properties
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4437354430324337");
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID).HasColumnName("INDIVIDUAL_REGISTRATION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.CONFIRMATION_NO).HasColumnName("CONFIRMATION_NO");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
