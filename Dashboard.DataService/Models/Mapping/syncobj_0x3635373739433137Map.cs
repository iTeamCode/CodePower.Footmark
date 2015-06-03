using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3635373739433137Map : EntityTypeConfiguration<syncobj_0x3635373739433137>
    {
        public syncobj_0x3635373739433137Map()
        {
            // Primary Key
            this.HasKey(t => new { t.QUESTION_TEXT_ID, t.CHURCH_ID, t.DATA_TYPE_ID, t.QUESTION_TEXT, t.IS_ACTIVE, t.IS_REQUIRED });

            // Properties
            this.Property(t => t.QUESTION_TEXT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DATA_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QUESTION_TEXT)
                .IsRequired()
                .HasMaxLength(125);

            this.Property(t => t.OPTIONAL_TEXT)
                .HasMaxLength(4000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.DELETED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3635373739433137");
            this.Property(t => t.QUESTION_TEXT_ID).HasColumnName("QUESTION_TEXT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.DATA_TYPE_ID).HasColumnName("DATA_TYPE_ID");
            this.Property(t => t.OPTION_TABLE_ID).HasColumnName("OPTION_TABLE_ID");
            this.Property(t => t.QUESTION_TEXT).HasColumnName("QUESTION_TEXT");
            this.Property(t => t.OPTIONAL_TEXT).HasColumnName("OPTIONAL_TEXT");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.IS_REQUIRED).HasColumnName("IS_REQUIRED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.DELETED_DATE).HasColumnName("DELETED_DATE");
            this.Property(t => t.DELETED_BY_LOGIN).HasColumnName("DELETED_BY_LOGIN");
            this.Property(t => t.DELETED_BY_USER_ID).HasColumnName("DELETED_BY_USER_ID");
            this.Property(t => t.IS_DELETED).HasColumnName("IS_DELETED");
        }
    }
}
