using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class TAG_TEMPLATE_ITEMMap : EntityTypeConfiguration<TAG_TEMPLATE_ITEM>
    {
        public TAG_TEMPLATE_ITEMMap()
        {
            // Primary Key
            this.HasKey(t => t.TAG_TEMPLATE_ITEM_ID);

            // Properties
            this.Property(t => t.STATIC_TEXT)
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("TAG_TEMPLATE_ITEM");
            this.Property(t => t.TAG_TEMPLATE_ITEM_ID).HasColumnName("TAG_TEMPLATE_ITEM_ID");
            this.Property(t => t.TAG_TEMPLATE_ID).HasColumnName("TAG_TEMPLATE_ID");
            this.Property(t => t.TAG_ITEM_ID).HasColumnName("TAG_ITEM_ID");
            this.Property(t => t.TAG_DATA_FIELD_ID).HasColumnName("TAG_DATA_FIELD_ID");
            this.Property(t => t.TAG_LOGO_ID).HasColumnName("TAG_LOGO_ID");
            this.Property(t => t.STATIC_TEXT).HasColumnName("STATIC_TEXT");
            this.Property(t => t.START_POINT_X).HasColumnName("START_POINT_X");
            this.Property(t => t.START_POINT_Y).HasColumnName("START_POINT_Y");
            this.Property(t => t.END_POINT_X).HasColumnName("END_POINT_X");
            this.Property(t => t.END_POINT_Y).HasColumnName("END_POINT_Y");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasOptional(t => t.TAG_DATA_FIELD)
                .WithMany(t => t.TAG_TEMPLATE_ITEM)
                .HasForeignKey(d => d.TAG_DATA_FIELD_ID);
            this.HasRequired(t => t.TAG_ITEM)
                .WithMany(t => t.TAG_TEMPLATE_ITEM)
                .HasForeignKey(d => d.TAG_ITEM_ID);
            this.HasOptional(t => t.TAG_LOGO)
                .WithMany(t => t.TAG_TEMPLATE_ITEM)
                .HasForeignKey(d => d.TAG_LOGO_ID);
            this.HasRequired(t => t.TAG_TEMPLATE)
                .WithMany(t => t.TAG_TEMPLATE_ITEM)
                .HasForeignKey(d => d.TAG_TEMPLATE_ID);

        }
    }
}
