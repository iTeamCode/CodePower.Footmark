using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_ITEM_TYPEMap : EntityTypeConfiguration<FORM_ITEM_TYPE>
    {
        public FORM_ITEM_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_ITEM_TYPE_ID);

            // Properties
            this.Property(t => t.FORM_ITEM_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FORM_ITEM_TYPE_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_ITEM_TYPE");
            this.Property(t => t.FORM_ITEM_TYPE_ID).HasColumnName("FORM_ITEM_TYPE_ID");
            this.Property(t => t.FORM_ITEM_TYPE_NAME).HasColumnName("FORM_ITEM_TYPE_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
