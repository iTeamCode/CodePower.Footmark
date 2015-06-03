using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class activity_instance_date_helperMap : EntityTypeConfiguration<activity_instance_date_helper>
    {
        public activity_instance_date_helperMap()
        {
            // Primary Key
            this.HasKey(t => t.date_id);

            // Properties
            // Table & Column Mappings
            this.ToTable("activity_instance_date_helper");
            this.Property(t => t.date_id).HasColumnName("date_id");
            this.Property(t => t.datesequence).HasColumnName("datesequence");
        }
    }
}
