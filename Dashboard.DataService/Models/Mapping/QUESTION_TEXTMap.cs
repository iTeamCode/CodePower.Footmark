using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class QUESTION_TEXTMap : EntityTypeConfiguration<QUESTION_TEXT>
    {
        public QUESTION_TEXTMap()
        {
            // Primary Key
            this.HasKey(t => t.QUESTION_TEXT_ID);

            // Properties
            this.Property(t => t.QUESTION_TEXT1)
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
            this.ToTable("QUESTION_TEXT");
            this.Property(t => t.QUESTION_TEXT_ID).HasColumnName("QUESTION_TEXT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.DATA_TYPE_ID).HasColumnName("DATA_TYPE_ID");
            this.Property(t => t.OPTION_TABLE_ID).HasColumnName("OPTION_TABLE_ID");
            this.Property(t => t.QUESTION_TEXT1).HasColumnName("QUESTION_TEXT");
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

            // Relationships
            this.HasRequired(t => t.DATA_TYPE)
                .WithMany(t => t.QUESTION_TEXT)
                .HasForeignKey(d => d.DATA_TYPE_ID);
            this.HasOptional(t => t.OPTION_TABLE)
                .WithMany(t => t.QUESTION_TEXT)
                .HasForeignKey(d => d.OPTION_TABLE_ID);

        }
    }
}
