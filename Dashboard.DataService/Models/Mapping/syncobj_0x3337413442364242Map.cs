using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3337413442364242Map : EntityTypeConfiguration<syncobj_0x3337413442364242>
    {
        public syncobj_0x3337413442364242Map()
        {
            // Primary Key
            this.HasKey(t => new { t.QUESTION_TEXT_ID, t.CHURCH_ID });

            // Properties
            this.Property(t => t.QUESTION_TEXT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VALIDATION_EXPRESSION_TYPE)
                .HasMaxLength(200);

            this.Property(t => t.VALIDATION_MESSAGE)
                .HasMaxLength(400);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.DELETED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3337413442364242");
            this.Property(t => t.QUESTION_TEXT_ID).HasColumnName("QUESTION_TEXT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.DEFAULT_VALUE).HasColumnName("DEFAULT_VALUE");
            this.Property(t => t.VALIDATION_EXPRESSION_TYPE).HasColumnName("VALIDATION_EXPRESSION_TYPE");
            this.Property(t => t.VALIDATION_MESSAGE).HasColumnName("VALIDATION_MESSAGE");
            this.Property(t => t.ANSWER_MINIMUM_VALUE).HasColumnName("ANSWER_MINIMUM_VALUE");
            this.Property(t => t.ANSWER_MAXIMUM_VALUE).HasColumnName("ANSWER_MAXIMUM_VALUE");
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
