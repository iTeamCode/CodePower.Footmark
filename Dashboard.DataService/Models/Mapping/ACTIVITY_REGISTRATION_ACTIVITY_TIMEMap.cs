using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_REGISTRATION_ACTIVITY_TIMEMap : EntityTypeConfiguration<ACTIVITY_REGISTRATION_ACTIVITY_TIME>
    {
        public ACTIVITY_REGISTRATION_ACTIVITY_TIMEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_REGISTRATION_ID, t.ACTIVITY_TIME_ID });

            // Properties
            this.Property(t => t.ACTIVITY_REGISTRATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_TIME_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_REGISTRATION_ACTIVITY_TIME");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_REGISTRATION)
                .WithMany(t => t.ACTIVITY_REGISTRATION_ACTIVITY_TIME)
                .HasForeignKey(d => d.ACTIVITY_REGISTRATION_ID);
            this.HasRequired(t => t.ACTIVITY_TIME)
                .WithMany(t => t.ACTIVITY_REGISTRATION_ACTIVITY_TIME)
                .HasForeignKey(d => d.ACTIVITY_TIME_ID);

        }
    }
}
