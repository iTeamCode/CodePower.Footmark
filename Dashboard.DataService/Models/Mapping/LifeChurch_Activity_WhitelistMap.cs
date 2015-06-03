using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class LifeChurch_Activity_WhitelistMap : EntityTypeConfiguration<LifeChurch_Activity_Whitelist>
    {
        public LifeChurch_Activity_WhitelistMap()
        {
            // Primary Key
            this.HasKey(t => t.ActivityID);

            // Properties
            this.Property(t => t.ActivityID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("LifeChurch_Activity_Whitelist");
            this.Property(t => t.ActivityID).HasColumnName("ActivityID");
        }
    }
}
