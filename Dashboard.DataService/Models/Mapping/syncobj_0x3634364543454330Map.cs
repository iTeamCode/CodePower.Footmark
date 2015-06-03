using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3634364543454330Map : EntityTypeConfiguration<syncobj_0x3634364543454330>
    {
        public syncobj_0x3634364543454330Map()
        {
            // Primary Key
            this.HasKey(t => new { t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID, t.CHURCH_ID, t.INDIVIDUAL_ID, t.VOLUNTEER_APPLICATION_ID, t.CREATED_DATETIME, t.REJECTED });

            // Properties
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VOLUNTEER_APPLICATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3634364543454330");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.VOLUNTEER_APPLICATION_ID).HasColumnName("VOLUNTEER_APPLICATION_ID");
            this.Property(t => t.CREATED_DATETIME).HasColumnName("CREATED_DATETIME");
            this.Property(t => t.COMMENT).HasColumnName("COMMENT");
            this.Property(t => t.REJECTED).HasColumnName("REJECTED");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
