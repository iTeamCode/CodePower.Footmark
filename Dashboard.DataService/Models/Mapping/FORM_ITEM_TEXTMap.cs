using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_ITEM_TEXTMap : EntityTypeConfiguration<FORM_ITEM_TEXT>
    {
        public FORM_ITEM_TEXTMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_ITEM_ID);

            // Properties
            this.Property(t => t.FORM_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DEFAULT_VALUE)
                .HasMaxLength(50);

            this.Property(t => t.VALIDATION_EXPRESSION_TYPE)
                .HasMaxLength(25);

            this.Property(t => t.VALIDATION_MESSAGE)
                .HasMaxLength(200);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_ITEM_TEXT");
            this.Property(t => t.FORM_ITEM_ID).HasColumnName("FORM_ITEM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.MAX_LENGTH).HasColumnName("MAX_LENGTH");
            this.Property(t => t.DEFAULT_VALUE).HasColumnName("DEFAULT_VALUE");
            this.Property(t => t.VALIDATION_EXPRESSION_TYPE).HasColumnName("VALIDATION_EXPRESSION_TYPE");
            this.Property(t => t.VALIDATION_MESSAGE).HasColumnName("VALIDATION_MESSAGE");
            this.Property(t => t.MULTI_LINE).HasColumnName("MULTI_LINE");
            this.Property(t => t.MULTI_BOX).HasColumnName("MULTI_BOX");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.FORM_ITEM)
                .WithOptional(t => t.FORM_ITEM_TEXT);

        }
    }
}
