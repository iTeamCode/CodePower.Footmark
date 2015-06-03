using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_CUSTOMMap : EntityTypeConfiguration<REGISTRATION_CUSTOM>
    {
        public REGISTRATION_CUSTOMMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_CUSTOM_ID);

            // Properties
            this.Property(t => t.CUSTOM_FIELD_NAME)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_CUSTOM");
            this.Property(t => t.REGISTRATION_CUSTOM_ID).HasColumnName("REGISTRATION_CUSTOM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.FIELD_NO).HasColumnName("FIELD_NO");
            this.Property(t => t.CUSTOM_FIELD_NAME).HasColumnName("CUSTOM_FIELD_NAME");
            this.Property(t => t.USE_LOV).HasColumnName("USE_LOV");
            this.Property(t => t.FIELD_SIZE).HasColumnName("FIELD_SIZE");
            this.Property(t => t.SORT).HasColumnName("SORT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.REGISTRATION_CUSTOM)
                .HasForeignKey(d => d.ACTIVITY_ID);

        }
    }
}
