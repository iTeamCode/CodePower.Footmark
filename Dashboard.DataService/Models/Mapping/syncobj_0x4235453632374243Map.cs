using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4235453632374243Map : EntityTypeConfiguration<syncobj_0x4235453632374243>
    {
        public syncobj_0x4235453632374243Map()
        {
            // Primary Key
            this.HasKey(t => new { t.JOB_ATTRIBUTE_GROUP_ID, t.CHURCH_ID, t.JOB_ATTRIBUTE_GROUP_NAME, t.IS_DELETED, t.CREATED_DATE });

            // Properties
            this.Property(t => t.JOB_ATTRIBUTE_GROUP_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JOB_ATTRIBUTE_GROUP_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4235453632374243");
            this.Property(t => t.JOB_ATTRIBUTE_GROUP_ID).HasColumnName("JOB_ATTRIBUTE_GROUP_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.JOB_ATTRIBUTE_GROUP_NAME).HasColumnName("JOB_ATTRIBUTE_GROUP_NAME");
            this.Property(t => t.IS_DELETED).HasColumnName("IS_DELETED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
