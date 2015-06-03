using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class VOLUNTEER_OPPORTUNITYMap : EntityTypeConfiguration<VOLUNTEER_OPPORTUNITY>
    {
        public VOLUNTEER_OPPORTUNITYMap()
        {
            // Primary Key
            this.HasKey(t => t.VOLUNTEER_OPPORTUNITY_ID);

            // Properties
            this.Property(t => t.DESCRIPTION)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.OPPORTUNITY_DESCRIPTION)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("VOLUNTEER_OPPORTUNITY");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.VOLUNTEER_APPLICATION_ID).HasColumnName("VOLUNTEER_APPLICATION_ID");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.MINISTRY_ID).HasColumnName("MINISTRY_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.INDIVIDUAL_GROUP_ID).HasColumnName("INDIVIDUAL_GROUP_ID");
            this.Property(t => t.STAFFING_SCHEDULE_ID).HasColumnName("STAFFING_SCHEDULE_ID");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.OPPORTUNITY_DESCRIPTION).HasColumnName("OPPORTUNITY_DESCRIPTION");

            // Relationships
            this.HasRequired(t => t.VOLUNTEER_APPLICATION)
                .WithMany(t => t.VOLUNTEER_OPPORTUNITY)
                .HasForeignKey(d => d.VOLUNTEER_APPLICATION_ID);

        }
    }
}
