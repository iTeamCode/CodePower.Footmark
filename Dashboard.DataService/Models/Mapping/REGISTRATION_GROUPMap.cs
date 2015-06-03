using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_GROUPMap : EntityTypeConfiguration<REGISTRATION_GROUP>
    {
        public REGISTRATION_GROUPMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_GROUP_ID);

            // Properties
            this.Property(t => t.REGISTRATION_GROUP_NAME)
                .HasMaxLength(100);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_GROUP");
            this.Property(t => t.REGISTRATION_GROUP_ID).HasColumnName("REGISTRATION_GROUP_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.REGISTRATION_GROUP_NAME).HasColumnName("REGISTRATION_GROUP_NAME");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.IS_GLOBAL_GROUP).HasColumnName("IS_GLOBAL_GROUP");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_REGISTRATION)
                .WithMany(t => t.REGISTRATION_GROUP)
                .HasForeignKey(d => d.ACTIVITY_REGISTRATION_ID);

        }
    }
}
