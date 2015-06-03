using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class JOB_ATTRIBUTE_GROUPMap : EntityTypeConfiguration<JOB_ATTRIBUTE_GROUP>
    {
        public JOB_ATTRIBUTE_GROUPMap()
        {
            // Primary Key
            this.HasKey(t => t.JOB_ATTRIBUTE_GROUP_ID);

            // Properties
            this.Property(t => t.JOB_ATTRIBUTE_GROUP_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("JOB_ATTRIBUTE_GROUP");
            this.Property(t => t.JOB_ATTRIBUTE_GROUP_ID).HasColumnName("JOB_ATTRIBUTE_GROUP_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.JOB_ATTRIBUTE_GROUP_NAME).HasColumnName("JOB_ATTRIBUTE_GROUP_NAME");
            this.Property(t => t.IS_DELETED).HasColumnName("IS_DELETED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
