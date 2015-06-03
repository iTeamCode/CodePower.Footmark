using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_RECURRENCEMap : EntityTypeConfiguration<ACTIVITY_RECURRENCE>
    {
        public ACTIVITY_RECURRENCEMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_RECURRENCE_ID);

            // Properties
            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_RECURRENCE");
            this.Property(t => t.ACTIVITY_RECURRENCE_ID).HasColumnName("ACTIVITY_RECURRENCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
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
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasOptional(t => t.ACTIVITY_TIME)
                .WithMany(t => t.ACTIVITY_RECURRENCE)
                .HasForeignKey(d => d.ACTIVITY_TIME_ID);

        }
    }
}
