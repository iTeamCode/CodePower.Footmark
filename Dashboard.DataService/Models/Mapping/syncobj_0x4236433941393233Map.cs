using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4236433941393233Map : EntityTypeConfiguration<syncobj_0x4236433941393233>
    {
        public syncobj_0x4236433941393233Map()
        {
            // Primary Key
            this.HasKey(t => new { t.INDIVIDUAL_TYPE_GROUP_ID, t.INDIVIDUAL_TYPE_GROUP_NAME });

            // Properties
            this.Property(t => t.INDIVIDUAL_TYPE_GROUP_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_TYPE_GROUP_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4236433941393233");
            this.Property(t => t.INDIVIDUAL_TYPE_GROUP_ID).HasColumnName("INDIVIDUAL_TYPE_GROUP_ID");
            this.Property(t => t.INDIVIDUAL_TYPE_GROUP_NAME).HasColumnName("INDIVIDUAL_TYPE_GROUP_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_USER_ID).HasColumnName("LAST_UPDATED_USER_ID");
        }
    }
}
