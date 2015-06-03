using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_ITEMMap : EntityTypeConfiguration<REGISTRATION_ITEM>
    {
        public REGISTRATION_ITEMMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_ITEM_ID);

            // Properties
            this.Property(t => t.REGISTRATION_ITEM_NAME)
                .HasMaxLength(50);

            this.Property(t => t.REGISTRATION_ITEM_DESC)
                .HasMaxLength(500);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_ITEM");
            this.Property(t => t.REGISTRATION_ITEM_ID).HasColumnName("REGISTRATION_ITEM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.REGISTRATION_GROUP_ID).HasColumnName("REGISTRATION_GROUP_ID");
            this.Property(t => t.REGISTRATION_ITEM_NAME).HasColumnName("REGISTRATION_ITEM_NAME");
            this.Property(t => t.REGISTRATION_ITEM_DESC).HasColumnName("REGISTRATION_ITEM_DESC");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.IS_LOV).HasColumnName("IS_LOV");
            this.Property(t => t.MAX_LOV_ALLOWED).HasColumnName("MAX_LOV_ALLOWED");
            this.Property(t => t.IS_ACTIVITY_DETAIL).HasColumnName("IS_ACTIVITY_DETAIL");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
            this.Property(t => t.REGISTRATION_ITEM_TYPE_ID).HasColumnName("REGISTRATION_ITEM_TYPE_ID");
            this.Property(t => t.IS_REQUIRED).HasColumnName("IS_REQUIRED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.REGISTRATION_GROUP)
                .WithMany(t => t.REGISTRATION_ITEM)
                .HasForeignKey(d => d.REGISTRATION_GROUP_ID);
            this.HasRequired(t => t.REGISTRATION_ITEM_TYPE)
                .WithMany(t => t.REGISTRATION_ITEM)
                .HasForeignKey(d => d.REGISTRATION_ITEM_TYPE_ID);

        }
    }
}
