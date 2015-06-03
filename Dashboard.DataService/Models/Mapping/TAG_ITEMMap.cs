using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class TAG_ITEMMap : EntityTypeConfiguration<TAG_ITEM>
    {
        public TAG_ITEMMap()
        {
            // Primary Key
            this.HasKey(t => t.TAG_ITEM_ID);

            // Properties
            this.Property(t => t.TAG_ITEM_DESC)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("TAG_ITEM");
            this.Property(t => t.TAG_ITEM_ID).HasColumnName("TAG_ITEM_ID");
            this.Property(t => t.TAG_ITEM_DESC).HasColumnName("TAG_ITEM_DESC");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
