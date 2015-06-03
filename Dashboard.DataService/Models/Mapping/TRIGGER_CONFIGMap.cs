using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class TRIGGER_CONFIGMap : EntityTypeConfiguration<TRIGGER_CONFIG>
    {
        public TRIGGER_CONFIGMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TRIGGER_NAME, t.IS_ENABLED });

            // Properties
            this.Property(t => t.TRIGGER_NAME)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TRIGGER_CONFIG");
            this.Property(t => t.TRIGGER_NAME).HasColumnName("TRIGGER_NAME");
            this.Property(t => t.IS_ENABLED).HasColumnName("IS_ENABLED");
        }
    }
}
