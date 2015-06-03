using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4437303733393732Map : EntityTypeConfiguration<syncobj_0x4437303733393732>
    {
        public syncobj_0x4437303733393732Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_GROUP_ID, t.CHURCH_ID, t.ACTIVITY_ID, t.ACTIVITY_GROUP_NAME, t.ACTIVITY_GROUP_SORT, t.CHECKIN_BALANCE_TYPE });

            // Properties
            this.Property(t => t.ACTIVITY_GROUP_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_GROUP_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ACTIVITY_GROUP_SORT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHECKIN_BALANCE_TYPE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4437303733393732");
            this.Property(t => t.ACTIVITY_GROUP_ID).HasColumnName("ACTIVITY_GROUP_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_GROUP_NAME).HasColumnName("ACTIVITY_GROUP_NAME");
            this.Property(t => t.ACTIVITY_SUPER_GROUP_ID).HasColumnName("ACTIVITY_SUPER_GROUP_ID");
            this.Property(t => t.ACTIVITY_GROUP_SORT).HasColumnName("ACTIVITY_GROUP_SORT");
            this.Property(t => t.CHECKIN_BALANCE_TYPE).HasColumnName("CHECKIN_BALANCE_TYPE");
            this.Property(t => t.OLD_ACT_GRP_ID).HasColumnName("OLD_ACT_GRP_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.OLD_ACT_SUPER_GRP_ID).HasColumnName("OLD_ACT_SUPER_GRP_ID");
        }
    }
}
