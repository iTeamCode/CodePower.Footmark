using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3432393232333731Map : EntityTypeConfiguration<syncobj_0x3432393232333731>
    {
        public syncobj_0x3432393232333731Map()
        {
            // Primary Key
            this.HasKey(t => new { t.GFT_JOB_ID, t.GFT_CATEGORY_ID, t.GFT_ATTRIBUTE_ID, t.CHURCH_ID, t.RANK, t.CREATED_DATE, t.LAST_UPDATED_DATE });

            // Properties
            this.Property(t => t.GFT_JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GFT_CATEGORY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GFT_ATTRIBUTE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RANK)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3432393232333731");
            this.Property(t => t.GFT_JOB_ID).HasColumnName("GFT_JOB_ID");
            this.Property(t => t.GFT_CATEGORY_ID).HasColumnName("GFT_CATEGORY_ID");
            this.Property(t => t.GFT_ATTRIBUTE_ID).HasColumnName("GFT_ATTRIBUTE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.RANK).HasColumnName("RANK");
            this.Property(t => t.CUSTOM_WEIGHT_PERCENTAGE).HasColumnName("CUSTOM_WEIGHT_PERCENTAGE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
