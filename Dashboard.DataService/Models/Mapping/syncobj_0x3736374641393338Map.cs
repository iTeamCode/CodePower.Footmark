using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3736374641393338Map : EntityTypeConfiguration<syncobj_0x3736374641393338>
    {
        public syncobj_0x3736374641393338Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_PROPERTY_LOV_ID, t.CHURCH_ID, t.ACTIVITY_PROPERTY_ID, t.ACTIVITY_PROPERTY_LOV_NAME });

            // Properties
            this.Property(t => t.ACTIVITY_PROPERTY_LOV_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_PROPERTY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_PROPERTY_LOV_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3736374641393338");
            this.Property(t => t.ACTIVITY_PROPERTY_LOV_ID).HasColumnName("ACTIVITY_PROPERTY_LOV_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_PROPERTY_ID).HasColumnName("ACTIVITY_PROPERTY_ID");
            this.Property(t => t.ACTIVITY_PROPERTY_LOV_NAME).HasColumnName("ACTIVITY_PROPERTY_LOV_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
