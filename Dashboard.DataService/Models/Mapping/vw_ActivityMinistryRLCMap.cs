using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class vw_ActivityMinistryRLCMap : EntityTypeConfiguration<vw_ActivityMinistryRLC>
    {
        public vw_ActivityMinistryRLCMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Church_ID, t.Ministry_ID, t.Ministry_Name, t.Ministry_Active });

            // Properties
            this.Property(t => t.Church_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ministry_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ministry_Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Activity_Name)
                .HasMaxLength(30);

            this.Property(t => t.Activity_Detail_Name)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("vw_ActivityMinistryRLC");
            this.Property(t => t.Church_ID).HasColumnName("Church_ID");
            this.Property(t => t.Ministry_ID).HasColumnName("Ministry_ID");
            this.Property(t => t.Activity_ID).HasColumnName("Activity_ID");
            this.Property(t => t.Activity_Detail_ID).HasColumnName("Activity_Detail_ID");
            this.Property(t => t.Ministry_Name).HasColumnName("Ministry_Name");
            this.Property(t => t.Activity_Name).HasColumnName("Activity_Name");
            this.Property(t => t.Activity_Detail_Name).HasColumnName("Activity_Detail_Name");
            this.Property(t => t.Ministry_Active).HasColumnName("Ministry_Active");
            this.Property(t => t.Activity_Active).HasColumnName("Activity_Active");
            this.Property(t => t.RLC_Active).HasColumnName("RLC_Active");
        }
    }
}
