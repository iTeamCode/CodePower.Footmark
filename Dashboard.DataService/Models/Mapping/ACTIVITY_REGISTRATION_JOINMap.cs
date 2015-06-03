using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_REGISTRATION_JOINMap : EntityTypeConfiguration<ACTIVITY_REGISTRATION_JOIN>
    {
        public ACTIVITY_REGISTRATION_JOINMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_REGISTRATION_PARENT_ID, t.ACTIVITY_REGISTRATION_CHILD_ID });

            // Properties
            this.Property(t => t.ACTIVITY_REGISTRATION_PARENT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_REGISTRATION_CHILD_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_REGISTRATION_JOIN");
            this.Property(t => t.ACTIVITY_REGISTRATION_PARENT_ID).HasColumnName("ACTIVITY_REGISTRATION_PARENT_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_CHILD_ID).HasColumnName("ACTIVITY_REGISTRATION_CHILD_ID");
            this.Property(t => t.TIME_RESTRICTED).HasColumnName("TIME_RESTRICTED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_REGISTRATION)
                .WithMany(t => t.ACTIVITY_REGISTRATION_JOIN)
                .HasForeignKey(d => d.ACTIVITY_REGISTRATION_PARENT_ID);
            this.HasRequired(t => t.ACTIVITY_REGISTRATION1)
                .WithMany(t => t.ACTIVITY_REGISTRATION_JOIN1)
                .HasForeignKey(d => d.ACTIVITY_REGISTRATION_CHILD_ID);

        }
    }
}
