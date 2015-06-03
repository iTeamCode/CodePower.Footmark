using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class AUTOMATIC_ATTENDANCE_RULEMap : EntityTypeConfiguration<AUTOMATIC_ATTENDANCE_RULE>
    {
        public AUTOMATIC_ATTENDANCE_RULEMap()
        {
            // Primary Key
            this.HasKey(t => t.AUTOMATIC_ATTENDANCE_RULE_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("AUTOMATIC_ATTENDANCE_RULE");
            this.Property(t => t.AUTOMATIC_ATTENDANCE_RULE_ID).HasColumnName("AUTOMATIC_ATTENDANCE_RULE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.MINISTRY_ID).HasColumnName("MINISTRY_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.HOUSEHOLD_HEAD_IND).HasColumnName("HOUSEHOLD_HEAD_IND");
            this.Property(t => t.HOUSEHOLD_SPOUSE_IND).HasColumnName("HOUSEHOLD_SPOUSE_IND");
            this.Property(t => t.HOUSEHOLD_CHILD_IND).HasColumnName("HOUSEHOLD_CHILD_IND");
            this.Property(t => t.CONTRIBUTOR_SPOUSE_IND).HasColumnName("CONTRIBUTOR_SPOUSE_IND");
            this.Property(t => t.CONTRIBUTOR_CHILD_IND).HasColumnName("CONTRIBUTOR_CHILD_IND");
            this.Property(t => t.CHILD_PARENT_IND).HasColumnName("CHILD_PARENT_IND");
            this.Property(t => t.CHILD_SIBLING_IND).HasColumnName("CHILD_SIBLING_IND");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.AUTOMATIC_ATTENDANCE_RULE)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasRequired(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.AUTOMATIC_ATTENDANCE_RULE)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasRequired(t => t.MINISTRY)
                .WithMany(t => t.AUTOMATIC_ATTENDANCE_RULE)
                .HasForeignKey(d => d.MINISTRY_ID);

        }
    }
}
