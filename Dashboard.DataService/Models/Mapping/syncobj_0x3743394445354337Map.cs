using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3743394445354337Map : EntityTypeConfiguration<syncobj_0x3743394445354337>
    {
        public syncobj_0x3743394445354337Map()
        {
            // Primary Key
            this.HasKey(t => new { t.JOB_ID, t.STATUS_GROUP_ID, t.STATUS_ID, t.STATUS_SELECTLIST, t.CHURCH_ID, t.CREATED_DATE, t.JOB_STATUS_RESTRICTION_ID });

            // Properties
            this.Property(t => t.JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STATUS_GROUP_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STATUS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STATUS_SELECTLIST)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.JOB_STATUS_RESTRICTION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3743394445354337");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.STATUS_GROUP_ID).HasColumnName("STATUS_GROUP_ID");
            this.Property(t => t.STATUS_ID).HasColumnName("STATUS_ID");
            this.Property(t => t.STATUS_SELECTLIST).HasColumnName("STATUS_SELECTLIST");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.JOB_STATUS_RESTRICTION_ID).HasColumnName("JOB_STATUS_RESTRICTION_ID");
        }
    }
}
