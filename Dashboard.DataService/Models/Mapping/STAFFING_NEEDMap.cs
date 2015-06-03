using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class STAFFING_NEEDMap : EntityTypeConfiguration<STAFFING_NEED>
    {
        public STAFFING_NEEDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JOB_ID, t.ACTIVITY_ID, t.ACTIVITY_TIME_ID });

            // Properties
            this.Property(t => t.JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_TIME_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("STAFFING_NEED");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.STAFF_COUNT).HasColumnName("STAFF_COUNT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.STAFFING_NEED)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasRequired(t => t.ACTIVITY_TIME)
                .WithMany(t => t.STAFFING_NEED)
                .HasForeignKey(d => d.ACTIVITY_TIME_ID);
            this.HasRequired(t => t.JOB)
                .WithMany(t => t.STAFFING_NEED)
                .HasForeignKey(d => d.JOB_ID);

        }
    }
}
