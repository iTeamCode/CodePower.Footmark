using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3636433230443546Map : EntityTypeConfiguration<syncobj_0x3636433230443546>
    {
        public syncobj_0x3636433230443546Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REFERENCE_INSTANCE_ID, t.REFERENCE_ID, t.USER_ID, t.CREATED_DATETIME, t.IS_COMPLETE });

            // Properties
            this.Property(t => t.REFERENCE_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.REFERENCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.USER_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3636433230443546");
            this.Property(t => t.REFERENCE_INSTANCE_ID).HasColumnName("REFERENCE_INSTANCE_ID");
            this.Property(t => t.REFERENCE_ID).HasColumnName("REFERENCE_ID");
            this.Property(t => t.USER_ID).HasColumnName("USER_ID");
            this.Property(t => t.CREATED_DATETIME).HasColumnName("CREATED_DATETIME");
            this.Property(t => t.IS_COMPLETE).HasColumnName("IS_COMPLETE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
