using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class STAFFING_SCHEDULE_EDITMap : EntityTypeConfiguration<STAFFING_SCHEDULE_EDIT>
    {
        public STAFFING_SCHEDULE_EDITMap()
        {
            // Primary Key
            this.HasKey(t => new { t.INDIVIDUAL_ID, t.INDIVIDUAL_TYPE_ID, t.ACTIVITY_DETAIL_ID, t.ACTIVITY_INSTANCE_ID });

            // Properties
            this.Property(t => t.INDIVIDUAL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOTE)
                .HasMaxLength(1000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("STAFFING_SCHEDULE_EDIT");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.INDIVIDUAL_TYPE_ID).HasColumnName("INDIVIDUAL_TYPE_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.EDIT_TYPE).HasColumnName("EDIT_TYPE");
            this.Property(t => t.NOTE).HasColumnName("NOTE");
            this.Property(t => t.INDIVIDUAL_GROUP_ID).HasColumnName("INDIVIDUAL_GROUP_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.STAFFING_SCHEDULE_EDIT)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasRequired(t => t.ACTIVITY_INSTANCE)
                .WithMany(t => t.STAFFING_SCHEDULE_EDIT)
                .HasForeignKey(d => d.ACTIVITY_INSTANCE_ID);
            this.HasRequired(t => t.INDIVIDUAL_TYPE)
                .WithMany(t => t.STAFFING_SCHEDULE_EDIT)
                .HasForeignKey(d => d.INDIVIDUAL_TYPE_ID);

        }
    }
}
