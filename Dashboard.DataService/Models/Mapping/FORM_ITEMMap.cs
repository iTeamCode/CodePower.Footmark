using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_ITEMMap : EntityTypeConfiguration<FORM_ITEM>
    {
        public FORM_ITEMMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_ITEM_ID);

            // Properties
            this.Property(t => t.TEXT)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.OPTIONAL_TEXT)
                .HasMaxLength(4000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_ITEM");
            this.Property(t => t.FORM_ITEM_ID).HasColumnName("FORM_ITEM_ID");
            this.Property(t => t.FORM_HEADER_ID).HasColumnName("FORM_HEADER_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.FORM_ITEM_TYPE_ID).HasColumnName("FORM_ITEM_TYPE_ID");
            this.Property(t => t.TEXT).HasColumnName("TEXT");
            this.Property(t => t.REQUIRED).HasColumnName("REQUIRED");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.OPTIONAL_TEXT).HasColumnName("OPTIONAL_TEXT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.FORM_HEADER)
                .WithMany(t => t.FORM_ITEM)
                .HasForeignKey(d => d.FORM_HEADER_ID);
            this.HasRequired(t => t.FORM_ITEM_TYPE)
                .WithMany(t => t.FORM_ITEM)
                .HasForeignKey(d => d.FORM_ITEM_TYPE_ID);

        }
    }
}
