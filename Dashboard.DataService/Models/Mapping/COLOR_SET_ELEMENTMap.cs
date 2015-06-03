using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class COLOR_SET_ELEMENTMap : EntityTypeConfiguration<COLOR_SET_ELEMENT>
    {
        public COLOR_SET_ELEMENTMap()
        {
            // Primary Key
            this.HasKey(t => t.COLOR_SET_ELEMENT_ID);

            // Properties
            this.Property(t => t.ELEMENT_VALUE)
                .IsRequired()
                .HasMaxLength(800);

            this.Property(t => t.CREATED_BY_LOGIN)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.DELETED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("COLOR_SET_ELEMENT");
            this.Property(t => t.COLOR_SET_ELEMENT_ID).HasColumnName("COLOR_SET_ELEMENT_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.COLOR_SET_ID).HasColumnName("COLOR_SET_ID");
            this.Property(t => t.ELEMENT_ID).HasColumnName("ELEMENT_ID");
            this.Property(t => t.ELEMENT_VALUE).HasColumnName("ELEMENT_VALUE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.DELETED_DATE).HasColumnName("DELETED_DATE");
            this.Property(t => t.DELETED_BY_LOGIN).HasColumnName("DELETED_BY_LOGIN");
            this.Property(t => t.DELETED_BY_USER_ID).HasColumnName("DELETED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.COLOR_SET)
                .WithMany(t => t.COLOR_SET_ELEMENT)
                .HasForeignKey(d => d.COLOR_SET_ID);
            this.HasRequired(t => t.ELEMENT)
                .WithMany(t => t.COLOR_SET_ELEMENT)
                .HasForeignKey(d => d.ELEMENT_ID);

        }
    }
}
