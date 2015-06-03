using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4241434236413538Map : EntityTypeConfiguration<syncobj_0x4241434236413538>
    {
        public syncobj_0x4241434236413538Map()
        {
            // Primary Key
            this.HasKey(t => new { t.JOB_ID, t.MARITAL_STATUS, t.CHURCH_ID, t.CREATED_DATE, t.CREATED_BY_LOGIN, t.JOB_MARITAL_STATUS_ID });

            // Properties
            this.Property(t => t.JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MARITAL_STATUS)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.JOB_MARITAL_STATUS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4241434236413538");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.MARITAL_STATUS).HasColumnName("MARITAL_STATUS");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_USER_ID).HasColumnName("LAST_UPDATED_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.JOB_MARITAL_STATUS_ID).HasColumnName("JOB_MARITAL_STATUS_ID");
        }
    }
}
