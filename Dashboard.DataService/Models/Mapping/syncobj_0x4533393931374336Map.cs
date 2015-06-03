using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4533393931374336Map : EntityTypeConfiguration<syncobj_0x4533393931374336>
    {
        public syncobj_0x4533393931374336Map()
        {
            // Primary Key
            this.HasKey(t => new { t.VOLUNTEER_OPPORTUNITY_ID, t.REQUIREMENT_ID });

            // Properties
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REQUIREMENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4533393931374336");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_ID");
            this.Property(t => t.REQUIREMENT_ID).HasColumnName("REQUIREMENT_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
