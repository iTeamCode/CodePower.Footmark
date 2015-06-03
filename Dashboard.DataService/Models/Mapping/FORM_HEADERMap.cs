using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_HEADERMap : EntityTypeConfiguration<FORM_HEADER>
    {
        public FORM_HEADERMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_HEADER_ID);

            // Properties
            this.Property(t => t.FORM_HEADER_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_HEADER");
            this.Property(t => t.FORM_HEADER_ID).HasColumnName("FORM_HEADER_ID");
            this.Property(t => t.FORM_PAGE_ID).HasColumnName("FORM_PAGE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.FORM_HEADER_NAME).HasColumnName("FORM_HEADER_NAME");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.IsShared).HasColumnName("IsShared");

            // Relationships
            this.HasRequired(t => t.FORM_PAGE)
                .WithMany(t => t.FORM_HEADER)
                .HasForeignKey(d => d.FORM_PAGE_ID);

        }
    }
}
