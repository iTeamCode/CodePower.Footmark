using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3135413731354535Map : EntityTypeConfiguration<syncobj_0x3135413731354535>
    {
        public syncobj_0x3135413731354535Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REGISTRATION_ITEM_LOV_ID, t.CHURCH_ID, t.REGISTRATION_ITEM_ID, t.REGISTRATION_ITEM_NAME, t.IS_DEFAULT });

            // Properties
            this.Property(t => t.REGISTRATION_ITEM_LOV_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_ITEM_NAME)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3135413731354535");
            this.Property(t => t.REGISTRATION_ITEM_LOV_ID).HasColumnName("REGISTRATION_ITEM_LOV_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.REGISTRATION_ITEM_ID).HasColumnName("REGISTRATION_ITEM_ID");
            this.Property(t => t.REGISTRATION_ITEM_NAME).HasColumnName("REGISTRATION_ITEM_NAME");
            this.Property(t => t.PRICE_PER_ITEM).HasColumnName("PRICE_PER_ITEM");
            this.Property(t => t.MAX_QUANTITY).HasColumnName("MAX_QUANTITY");
            this.Property(t => t.MAX_REGISTRATIONS).HasColumnName("MAX_REGISTRATIONS");
            this.Property(t => t.IS_DEFAULT).HasColumnName("IS_DEFAULT");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
