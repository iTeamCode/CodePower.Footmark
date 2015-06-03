using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3836413735414236Map : EntityTypeConfiguration<syncobj_0x3836413735414236>
    {
        public syncobj_0x3836413735414236Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_DETAIL_INSTANCE_ID, t.ACTIVITY_INSTANCE_ID, t.ACTIVITY_DETAIL_ID, t.CHURCH_ID });

            // Properties
            this.Property(t => t.ACTIVITY_DETAIL_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ACTIVITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3836413735414236");
            this.Property(t => t.ACTIVITY_DETAIL_INSTANCE_ID).HasColumnName("ACTIVITY_DETAIL_INSTANCE_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ATTENDANCE).HasColumnName("ATTENDANCE");
            this.Property(t => t.ACTUAL_MEETING_DATE).HasColumnName("ACTUAL_MEETING_DATE");
            this.Property(t => t.MEETING_NOTE).HasColumnName("MEETING_NOTE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
