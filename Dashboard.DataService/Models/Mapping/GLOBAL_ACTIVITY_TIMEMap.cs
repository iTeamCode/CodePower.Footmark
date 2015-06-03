using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class GLOBAL_ACTIVITY_TIMEMap : EntityTypeConfiguration<GLOBAL_ACTIVITY_TIME>
    {
        public GLOBAL_ACTIVITY_TIMEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GLOBAL_ACTIVITY_ID, t.ACTIVITY_TIME_ID });

            // Properties
            this.Property(t => t.GLOBAL_ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_TIME_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GLOBAL_ACTIVITY_TIME");
            this.Property(t => t.GLOBAL_ACTIVITY_ID).HasColumnName("GLOBAL_ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_TIME)
                .WithMany(t => t.GLOBAL_ACTIVITY_TIME)
                .HasForeignKey(d => d.ACTIVITY_TIME_ID);
            this.HasRequired(t => t.GLOBAL_ACTIVITY)
                .WithMany(t => t.GLOBAL_ACTIVITY_TIME)
                .HasForeignKey(d => d.GLOBAL_ACTIVITY_ID);

        }
    }
}
