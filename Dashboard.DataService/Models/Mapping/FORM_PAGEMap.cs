using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_PAGEMap : EntityTypeConfiguration<FORM_PAGE>
    {
        public FORM_PAGEMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_PAGE_ID);

            // Properties
            this.Property(t => t.FORM_PAGE_NAME)
                .HasMaxLength(50);

            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(300);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_PAGE");
            this.Property(t => t.FORM_PAGE_ID).HasColumnName("FORM_PAGE_ID");
            this.Property(t => t.FORM_ID).HasColumnName("FORM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.FORM_PAGE_NAME).HasColumnName("FORM_PAGE_NAME");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.FORM)
                .WithMany(t => t.FORM_PAGE)
                .HasForeignKey(d => d.FORM_ID);

        }
    }
}
