using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class STAFFING_PREFMap : EntityTypeConfiguration<STAFFING_PREF>
    {
        public STAFFING_PREFMap()
        {
            // Primary Key
            this.HasKey(t => t.STAFFING_PREF_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("STAFFING_PREF");
            this.Property(t => t.STAFFING_PREF_ID).HasColumnName("STAFFING_PREF_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.INDIVIDUAL_TYPE_ID).HasColumnName("INDIVIDUAL_TYPE_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.INDIVIDUAL_GROUP_ID).HasColumnName("INDIVIDUAL_GROUP_ID");
            this.Property(t => t.STAFFING_SCHEDULE_ID).HasColumnName("STAFFING_SCHEDULE_ID");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.ACTIVITY_GROUP_ID).HasColumnName("ACTIVITY_GROUP_ID");
            this.Property(t => t.LAST_UPDATE).HasColumnName("LAST_UPDATE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.Add_Individual).HasColumnName("Add_Individual");
            this.Property(t => t.MassActionID).HasColumnName("MassActionID");

            // Relationships
            this.HasOptional(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.STAFFING_PREF)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasOptional(t => t.ACTIVITY_TIME)
                .WithMany(t => t.STAFFING_PREF)
                .HasForeignKey(d => d.ACTIVITY_TIME_ID);
            this.HasRequired(t => t.INDIVIDUAL_TYPE)
                .WithMany(t => t.STAFFING_PREF)
                .HasForeignKey(d => d.INDIVIDUAL_TYPE_ID);
            this.HasOptional(t => t.JOB)
                .WithMany(t => t.STAFFING_PREF)
                .HasForeignKey(d => d.JOB_ID);
            this.HasRequired(t => t.STAFFING_SCHEDULE)
                .WithMany(t => t.STAFFING_PREF)
                .HasForeignKey(d => d.STAFFING_SCHEDULE_ID);

        }
    }
}