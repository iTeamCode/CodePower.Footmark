using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class CTRL_DATE_TABLEMap : EntityTypeConfiguration<CTRL_DATE_TABLE>
    {
        public CTRL_DATE_TABLEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CTRL_DATE_TABLE");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.start_date).HasColumnName("start_date");
            this.Property(t => t.End_date).HasColumnName("End_date");
            this.Property(t => t.processed_ind).HasColumnName("processed_ind");
        }
    }
}
