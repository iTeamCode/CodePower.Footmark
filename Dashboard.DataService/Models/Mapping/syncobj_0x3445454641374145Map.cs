using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3445454641374145Map : EntityTypeConfiguration<syncobj_0x3445454641374145>
    {
        public syncobj_0x3445454641374145Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_ID, t.ACTIVITY_NAME, t.HAS_CHECKIN, t.CHECKIN_MINUTES_BEFORE, t.HAS_NAMETAG, t.HAS_RECEIPT, t.CHURCH_ID, t.FIXED_TIMES, t.HAS_SECURITY_AUTHORIZATION, t.REQUIRES_REGISTRATION, t.INDIVIDUAL_PREF_BY, t.STAFFING_PREF_BY, t.DETAIL_BY_ACTIVITY_TIME, t.INDIVIDUAL_PREFS_OVERRIDE_CLOSED_ROOM, t.AUTO_PREF_OPTION });

            // Properties
            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ACTIVITY_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CHECKIN_MINUTES_BEFORE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FIXED_TIMES)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REQUIRES_REGISTRATION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_PREF_BY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STAFFING_PREF_BY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AUTO_PREF_OPTION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3445454641374145");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_NAME).HasColumnName("ACTIVITY_NAME");
            this.Property(t => t.HAS_CHECKIN).HasColumnName("HAS_CHECKIN");
            this.Property(t => t.CHECKIN_MINUTES_BEFORE).HasColumnName("CHECKIN_MINUTES_BEFORE");
            this.Property(t => t.HAS_NAMETAG).HasColumnName("HAS_NAMETAG");
            this.Property(t => t.HAS_RECEIPT).HasColumnName("HAS_RECEIPT");
            this.Property(t => t.START_AGE).HasColumnName("START_AGE");
            this.Property(t => t.END_AGE).HasColumnName("END_AGE");
            this.Property(t => t.EXTEND_START_AGE).HasColumnName("EXTEND_START_AGE");
            this.Property(t => t.EXTEND_END_AGE).HasColumnName("EXTEND_END_AGE");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CHECKIN_CODE).HasColumnName("CHECKIN_CODE");
            this.Property(t => t.FIXED_TIMES).HasColumnName("FIXED_TIMES");
            this.Property(t => t.HAS_SECURITY_AUTHORIZATION).HasColumnName("HAS_SECURITY_AUTHORIZATION");
            this.Property(t => t.REQUIRES_REGISTRATION).HasColumnName("REQUIRES_REGISTRATION");
            this.Property(t => t.TRACK_ATTENDANCE_BY_INDIVIDUAL).HasColumnName("TRACK_ATTENDANCE_BY_INDIVIDUAL");
            this.Property(t => t.INDIVIDUAL_PREF_BY).HasColumnName("INDIVIDUAL_PREF_BY");
            this.Property(t => t.STAFFING_PREF_BY).HasColumnName("STAFFING_PREF_BY");
            this.Property(t => t.DETAIL_BY_ACTIVITY_TIME).HasColumnName("DETAIL_BY_ACTIVITY_TIME");
            this.Property(t => t.INDIVIDUAL_PREFS_OVERRIDE_CLOSED_ROOM).HasColumnName("INDIVIDUAL_PREFS_OVERRIDE_CLOSED_ROOM");
            this.Property(t => t.AUTO_PREF_OPTION).HasColumnName("AUTO_PREF_OPTION");
            this.Property(t => t.CONTACT_ITEM_ID).HasColumnName("CONTACT_ITEM_ID");
            this.Property(t => t.WEB_ENABLED).HasColumnName("WEB_ENABLED");
            this.Property(t => t.OLD_ACT_ID).HasColumnName("OLD_ACT_ID");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.PAGER_ENABLED).HasColumnName("PAGER_ENABLED");
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
