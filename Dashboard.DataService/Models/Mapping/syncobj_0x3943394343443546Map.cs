using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3943394343443546Map : EntityTypeConfiguration<syncobj_0x3943394343443546>
    {
        public syncobj_0x3943394343443546Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REGISTRATION_GROUP_ID, t.CHURCH_ID, t.ACTIVITY_REGISTRATION_ID, t.SORT, t.IS_GLOBAL_GROUP });

            // Properties
            this.Property(t => t.REGISTRATION_GROUP_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_REGISTRATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_GROUP_NAME)
                .HasMaxLength(100);

            this.Property(t => t.SORT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3943394343443546");
            this.Property(t => t.REGISTRATION_GROUP_ID).HasColumnName("REGISTRATION_GROUP_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.REGISTRATION_GROUP_NAME).HasColumnName("REGISTRATION_GROUP_NAME");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.IS_GLOBAL_GROUP).HasColumnName("IS_GLOBAL_GROUP");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
