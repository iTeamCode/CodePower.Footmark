using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4446434332384236Map : EntityTypeConfiguration<syncobj_0x4446434332384236>
    {
        public syncobj_0x4446434332384236Map()
        {
            // Primary Key
            this.HasKey(t => new { t.JOB_ID, t.JOB_INFORMATION_ID, t.CHURCH_ID, t.INFORMATION_VALUE, t.CREATED_DATE, t.CREATED_BY_LOGIN, t.JOB_JOB_INFORMATION_ID });

            // Properties
            this.Property(t => t.JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JOB_INFORMATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INFORMATION_VALUE)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.JOB_JOB_INFORMATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4446434332384236");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.JOB_INFORMATION_ID).HasColumnName("JOB_INFORMATION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INFORMATION_VALUE).HasColumnName("INFORMATION_VALUE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.JOB_JOB_INFORMATION_ID).HasColumnName("JOB_JOB_INFORMATION_ID");
        }
    }
}
