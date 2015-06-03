using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3333363631303832Map : EntityTypeConfiguration<syncobj_0x3333363631303832>
    {
        public syncobj_0x3333363631303832Map()
        {
            // Primary Key
            this.HasKey(t => new { t.GLOBAL_ACTIVITY_ID, t.CHURCH_ID });

            // Properties
            this.Property(t => t.GLOBAL_ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GLOBAL_ACTIVITY_NAME)
                .HasMaxLength(60);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3333363631303832");
            this.Property(t => t.GLOBAL_ACTIVITY_ID).HasColumnName("GLOBAL_ACTIVITY_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.GLOBAL_ACTIVITY_NAME).HasColumnName("GLOBAL_ACTIVITY_NAME");
            this.Property(t => t.CHECKIN_CODE).HasColumnName("CHECKIN_CODE");
            this.Property(t => t.old_glbl_act_id).HasColumnName("old_glbl_act_id");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.THEME_ID).HasColumnName("THEME_ID");
        }
    }
}
