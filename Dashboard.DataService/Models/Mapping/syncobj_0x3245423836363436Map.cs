using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3245423836363436Map : EntityTypeConfiguration<syncobj_0x3245423836363436>
    {
        public syncobj_0x3245423836363436Map()
        {
            // Primary Key
            this.HasKey(t => new { t.STAFFING_RECURRENCE_ID, t.CHURCH_ID, t.STAFFING_SCHEDULE_ID, t.START_DATE, t.NO_END_DATE, t.END_AFTER_OCCURENCES, t.RECURRENCE_PATTERN, t.DAILY_EVERY_DAYS, t.WEEKLY_EVERY_WEEKS, t.WEEKLY_SUNDAY, t.WEEKLY_MONDAY, t.WEEKLY_TUESDAY, t.WEEKLY_WEDNESDAY, t.WEEKLY_THURSDAY, t.WEEKLY_FRIDAY, t.WEEKLY_SATURDAY, t.MONTHLY_DAY_MONTH, t.MONTHLY_EVERY_MONTH, t.MONTHLY_WEEK, t.MONTHLY_DAY_OF_WEEK, t.YEARLY_EVERY_MONTH, t.YEARLY_DAY_MONTH, t.YEARLY_WEEK, t.YEARLY_DAY_OF_WEEK });

            // Properties
            this.Property(t => t.STAFFING_RECURRENCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STAFFING_SCHEDULE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.END_AFTER_OCCURENCES)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RECURRENCE_PATTERN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DAILY_EVERY_DAYS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WEEKLY_EVERY_WEEKS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MONTHLY_DAY_MONTH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MONTHLY_EVERY_MONTH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MONTHLY_WEEK)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MONTHLY_DAY_OF_WEEK)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.YEARLY_EVERY_MONTH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.YEARLY_DAY_MONTH)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.YEARLY_WEEK)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.YEARLY_DAY_OF_WEEK)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3245423836363436");
            this.Property(t => t.STAFFING_RECURRENCE_ID).HasColumnName("STAFFING_RECURRENCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.STAFFING_SCHEDULE_ID).HasColumnName("STAFFING_SCHEDULE_ID");
            this.Property(t => t.START_DATE).HasColumnName("START_DATE");
            this.Property(t => t.NO_END_DATE).HasColumnName("NO_END_DATE");
            this.Property(t => t.END_AFTER_OCCURENCES).HasColumnName("END_AFTER_OCCURENCES");
            this.Property(t => t.END_DATE).HasColumnName("END_DATE");
            this.Property(t => t.RECURRENCE_PATTERN).HasColumnName("RECURRENCE_PATTERN");
            this.Property(t => t.DAILY_EVERY_DAYS).HasColumnName("DAILY_EVERY_DAYS");
            this.Property(t => t.WEEKLY_EVERY_WEEKS).HasColumnName("WEEKLY_EVERY_WEEKS");
            this.Property(t => t.WEEKLY_SUNDAY).HasColumnName("WEEKLY_SUNDAY");
            this.Property(t => t.WEEKLY_MONDAY).HasColumnName("WEEKLY_MONDAY");
            this.Property(t => t.WEEKLY_TUESDAY).HasColumnName("WEEKLY_TUESDAY");
            this.Property(t => t.WEEKLY_WEDNESDAY).HasColumnName("WEEKLY_WEDNESDAY");
            this.Property(t => t.WEEKLY_THURSDAY).HasColumnName("WEEKLY_THURSDAY");
            this.Property(t => t.WEEKLY_FRIDAY).HasColumnName("WEEKLY_FRIDAY");
            this.Property(t => t.WEEKLY_SATURDAY).HasColumnName("WEEKLY_SATURDAY");
            this.Property(t => t.MONTHLY_DAY_MONTH).HasColumnName("MONTHLY_DAY_MONTH");
            this.Property(t => t.MONTHLY_EVERY_MONTH).HasColumnName("MONTHLY_EVERY_MONTH");
            this.Property(t => t.MONTHLY_WEEK).HasColumnName("MONTHLY_WEEK");
            this.Property(t => t.MONTHLY_DAY_OF_WEEK).HasColumnName("MONTHLY_DAY_OF_WEEK");
            this.Property(t => t.YEARLY_EVERY_MONTH).HasColumnName("YEARLY_EVERY_MONTH");
            this.Property(t => t.YEARLY_DAY_MONTH).HasColumnName("YEARLY_DAY_MONTH");
            this.Property(t => t.YEARLY_WEEK).HasColumnName("YEARLY_WEEK");
            this.Property(t => t.YEARLY_DAY_OF_WEEK).HasColumnName("YEARLY_DAY_OF_WEEK");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}