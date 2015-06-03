using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3330344646443139Map : EntityTypeConfiguration<syncobj_0x3330344646443139>
    {
        public syncobj_0x3330344646443139Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_INSTANCE_ID, t.CHURCH_ID, t.ACTIVITY_ID, t.START_DATE_TIME });

            // Properties
            this.Property(t => t.ACTIVITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3330344646443139");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.START_DATE_TIME).HasColumnName("START_DATE_TIME");
            this.Property(t => t.START_CHECKIN).HasColumnName("START_CHECKIN");
            this.Property(t => t.END_CHECKIN).HasColumnName("END_CHECKIN");
            this.Property(t => t.ACTIVITY_SERIES_ID).HasColumnName("ACTIVITY_SERIES_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.OLD_ACT_INS_ID).HasColumnName("OLD_ACT_INS_ID");
        }
    }
}
