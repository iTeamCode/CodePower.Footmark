using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class RG_ACTIVITY_REGISTRATION_SCHEDULEMap : EntityTypeConfiguration<RG_ACTIVITY_REGISTRATION_SCHEDULE>
    {
        public RG_ACTIVITY_REGISTRATION_SCHEDULEMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_REGISTRATION_SCHEDULE_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("RG_ACTIVITY_REGISTRATION_SCHEDULE");
            this.Property(t => t.ACTIVITY_REGISTRATION_SCHEDULE_ID).HasColumnName("ACTIVITY_REGISTRATION_SCHEDULE_ID");
            this.Property(t => t.FORM_ID).HasColumnName("FORM_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasOptional(t => t.ACTIVITY_INSTANCE)
                .WithMany(t => t.RG_ACTIVITY_REGISTRATION_SCHEDULE)
                .HasForeignKey(d => d.ACTIVITY_INSTANCE_ID);
            this.HasOptional(t => t.ACTIVITY_TIME)
                .WithMany(t => t.RG_ACTIVITY_REGISTRATION_SCHEDULE)
                .HasForeignKey(d => d.ACTIVITY_TIME_ID);
            this.HasRequired(t => t.RG_ACTIVITY_REGISTRATION)
                .WithMany(t => t.RG_ACTIVITY_REGISTRATION_SCHEDULE)
                .HasForeignKey(d => d.FORM_ID);

        }
    }
}
