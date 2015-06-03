using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_ITEM_LOVMap : EntityTypeConfiguration<REGISTRATION_ITEM_LOV>
    {
        public REGISTRATION_ITEM_LOVMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_ITEM_LOV_ID);

            // Properties
            this.Property(t => t.REGISTRATION_ITEM_NAME)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_ITEM_LOV");
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

            // Relationships
            this.HasRequired(t => t.REGISTRATION_ITEM)
                .WithMany(t => t.REGISTRATION_ITEM_LOV)
                .HasForeignKey(d => d.REGISTRATION_ITEM_ID);

        }
    }
}
