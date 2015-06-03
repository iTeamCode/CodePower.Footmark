using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4644383232374341Map : EntityTypeConfiguration<syncobj_0x4644383232374341>
    {
        public syncobj_0x4644383232374341Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REGISTRATION_ITEM_ID, t.CHURCH_ID, t.REGISTRATION_GROUP_ID, t.SORT, t.IS_LOV, t.MAX_LOV_ALLOWED, t.IS_ACTIVITY_DETAIL, t.ENABLED, t.REGISTRATION_ITEM_TYPE_ID, t.IS_REQUIRED });

            // Properties
            this.Property(t => t.REGISTRATION_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_GROUP_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_ITEM_NAME)
                .HasMaxLength(50);

            this.Property(t => t.REGISTRATION_ITEM_DESC)
                .HasMaxLength(500);

            this.Property(t => t.SORT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MAX_LOV_ALLOWED)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_ITEM_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4644383232374341");
            this.Property(t => t.REGISTRATION_ITEM_ID).HasColumnName("REGISTRATION_ITEM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.REGISTRATION_GROUP_ID).HasColumnName("REGISTRATION_GROUP_ID");
            this.Property(t => t.REGISTRATION_ITEM_NAME).HasColumnName("REGISTRATION_ITEM_NAME");
            this.Property(t => t.REGISTRATION_ITEM_DESC).HasColumnName("REGISTRATION_ITEM_DESC");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.IS_LOV).HasColumnName("IS_LOV");
            this.Property(t => t.MAX_LOV_ALLOWED).HasColumnName("MAX_LOV_ALLOWED");
            this.Property(t => t.IS_ACTIVITY_DETAIL).HasColumnName("IS_ACTIVITY_DETAIL");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
            this.Property(t => t.REGISTRATION_ITEM_TYPE_ID).HasColumnName("REGISTRATION_ITEM_TYPE_ID");
            this.Property(t => t.IS_REQUIRED).HasColumnName("IS_REQUIRED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
