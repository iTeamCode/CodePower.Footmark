using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class JOB_INFORMATIONMap : EntityTypeConfiguration<JOB_INFORMATION>
    {
        public JOB_INFORMATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.JOB_INFORMATION_ID);

            // Properties
            this.Property(t => t.JOB_INFORMATION_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CREATED_BY_LOGIN)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("JOB_INFORMATION");
            this.Property(t => t.JOB_INFORMATION_ID).HasColumnName("JOB_INFORMATION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.JOB_INFORMATION_NAME).HasColumnName("JOB_INFORMATION_NAME");
            this.Property(t => t.MAX_LENGTH).HasColumnName("MAX_LENGTH");
            this.Property(t => t.REQUIRED).HasColumnName("REQUIRED");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.SHOW_ON_ASSESSMENT_REPORT).HasColumnName("SHOW_ON_ASSESSMENT_REPORT");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
