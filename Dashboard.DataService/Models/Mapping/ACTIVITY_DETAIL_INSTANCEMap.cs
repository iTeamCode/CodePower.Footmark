using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_DETAIL_INSTANCEMap : EntityTypeConfiguration<ACTIVITY_DETAIL_INSTANCE>
    {
        public ACTIVITY_DETAIL_INSTANCEMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_DETAIL_INSTANCE_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_DETAIL_INSTANCE");
            this.Property(t => t.ACTIVITY_DETAIL_INSTANCE_ID).HasColumnName("ACTIVITY_DETAIL_INSTANCE_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ATTENDANCE).HasColumnName("ATTENDANCE");
            this.Property(t => t.ACTUAL_MEETING_DATE).HasColumnName("ACTUAL_MEETING_DATE");
            this.Property(t => t.MEETING_NOTE).HasColumnName("MEETING_NOTE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.ACTIVITY_DETAIL_INSTANCE)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasRequired(t => t.ACTIVITY_INSTANCE)
                .WithMany(t => t.ACTIVITY_DETAIL_INSTANCE)
                .HasForeignKey(d => d.ACTIVITY_INSTANCE_ID);

        }
    }
}
