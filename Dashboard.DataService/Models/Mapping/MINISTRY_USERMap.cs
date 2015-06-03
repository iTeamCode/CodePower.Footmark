using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class MINISTRY_USERMap : EntityTypeConfiguration<MINISTRY_USER>
    {
        public MINISTRY_USERMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MINISTRY_ID, t.USER_ID, t.CHURCH_ID });

            // Properties
            this.Property(t => t.MINISTRY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.USER_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MINISTRY_USER");
            this.Property(t => t.MINISTRY_ID).HasColumnName("MINISTRY_ID");
            this.Property(t => t.USER_ID).HasColumnName("USER_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.SECURITY_TYPE_ID).HasColumnName("SECURITY_TYPE_ID");
        }
    }
}
