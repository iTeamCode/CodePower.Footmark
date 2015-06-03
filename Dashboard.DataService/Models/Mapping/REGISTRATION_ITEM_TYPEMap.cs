using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_ITEM_TYPEMap : EntityTypeConfiguration<REGISTRATION_ITEM_TYPE>
    {
        public REGISTRATION_ITEM_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_ITEM_TYPE_ID);

            // Properties
            this.Property(t => t.REGISTRATION_ITEM_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_ITEM_TYPE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_ITEM_TYPE");
            this.Property(t => t.REGISTRATION_ITEM_TYPE_ID).HasColumnName("REGISTRATION_ITEM_TYPE_ID");
            this.Property(t => t.REGISTRATION_ITEM_TYPE_NAME).HasColumnName("REGISTRATION_ITEM_TYPE_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
