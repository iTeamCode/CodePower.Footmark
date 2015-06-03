using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_CUSTOM_LOVMap : EntityTypeConfiguration<REGISTRATION_CUSTOM_LOV>
    {
        public REGISTRATION_CUSTOM_LOVMap()
        {
            // Primary Key
            this.HasKey(t => t.LIST_VALUE_ID);

            // Properties
            this.Property(t => t.LIST_VALUE)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_CUSTOM_LOV");
            this.Property(t => t.LIST_VALUE_ID).HasColumnName("LIST_VALUE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.REGISTRATION_CUSTOM_ID).HasColumnName("REGISTRATION_CUSTOM_ID");
            this.Property(t => t.LIST_VALUE).HasColumnName("LIST_VALUE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasOptional(t => t.REGISTRATION_CUSTOM)
                .WithMany(t => t.REGISTRATION_CUSTOM_LOV)
                .HasForeignKey(d => d.REGISTRATION_CUSTOM_ID);

        }
    }
}
