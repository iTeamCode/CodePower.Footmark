using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class TAG_TEMPLATEMap : EntityTypeConfiguration<TAG_TEMPLATE>
    {
        public TAG_TEMPLATEMap()
        {
            // Primary Key
            this.HasKey(t => t.TAG_TEMPLATE_ID);

            // Properties
            this.Property(t => t.TAG_TEMPLATE_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("TAG_TEMPLATE");
            this.Property(t => t.TAG_TEMPLATE_ID).HasColumnName("TAG_TEMPLATE_ID");
            this.Property(t => t.TAG_TEMPLATE_NAME).HasColumnName("TAG_TEMPLATE_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
