using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class Date_Range_TypeMap : EntityTypeConfiguration<Date_Range_Type>
    {
        public Date_Range_TypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Date_Range_Type_ID);

            // Properties
            this.Property(t => t.Date_Range_Type_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Date_Range_Type");
            this.Property(t => t.Date_Range_Type_ID).HasColumnName("Date_Range_Type_ID");
            this.Property(t => t.Date_Range_Type_Name).HasColumnName("Date_Range_Type_Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
