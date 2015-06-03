using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class TAG_LOGOMap : EntityTypeConfiguration<TAG_LOGO>
    {
        public TAG_LOGOMap()
        {
            // Primary Key
            this.HasKey(t => t.TAG_LOGO_ID);

            // Properties
            this.Property(t => t.TAG_LOGO_NAME)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.LOGO_IMAGE)
                .IsRequired();

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("TAG_LOGO");
            this.Property(t => t.TAG_LOGO_ID).HasColumnName("TAG_LOGO_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.TAG_LOGO_NAME).HasColumnName("TAG_LOGO_NAME");
            this.Property(t => t.LOGO_IMAGE).HasColumnName("LOGO_IMAGE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
