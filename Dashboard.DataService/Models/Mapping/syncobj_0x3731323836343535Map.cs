using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3731323836343535Map : EntityTypeConfiguration<syncobj_0x3731323836343535>
    {
        public syncobj_0x3731323836343535Map()
        {
            // Primary Key
            this.HasKey(t => new { t.GFT_JOB_ID, t.GFT_PROGRAM_ID, t.CHURCH_ID, t.ASSESSMENT_DATE, t.IS_TEMPLATE, t.IS_ACTIVE, t.CREATED_DATE, t.LAST_UPDATED_DATE });

            // Properties
            this.Property(t => t.GFT_JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GFT_PROGRAM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TEMPLATE_NAME)
                .HasMaxLength(40);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3731323836343535");
            this.Property(t => t.GFT_JOB_ID).HasColumnName("GFT_JOB_ID");
            this.Property(t => t.GFT_PROGRAM_ID).HasColumnName("GFT_PROGRAM_ID");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ASSESSMENT_DATE).HasColumnName("ASSESSMENT_DATE");
            this.Property(t => t.IS_TEMPLATE).HasColumnName("IS_TEMPLATE");
            this.Property(t => t.TEMPLATE_NAME).HasColumnName("TEMPLATE_NAME");
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