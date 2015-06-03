using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4242453445363334Map : EntityTypeConfiguration<syncobj_0x4242453445363334>
    {
        public syncobj_0x4242453445363334Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_PROPERTY_ID, t.CHURCH_ID, t.ACTIVITY_ID, t.ACTIVITY_PROPERTY_NAME, t.IS_FILTER_CHOICE, t.SHOW_RESULTS });

            // Properties
            this.Property(t => t.ACTIVITY_PROPERTY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_PROPERTY_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4242453445363334");
            this.Property(t => t.ACTIVITY_PROPERTY_ID).HasColumnName("ACTIVITY_PROPERTY_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_PROPERTY_NAME).HasColumnName("ACTIVITY_PROPERTY_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.IS_FILTER_CHOICE).HasColumnName("IS_FILTER_CHOICE");
            this.Property(t => t.SHOW_RESULTS).HasColumnName("SHOW_RESULTS");
        }
    }
}
