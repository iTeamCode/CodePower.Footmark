using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4631323442334233Map : EntityTypeConfiguration<syncobj_0x4631323442334233>
    {
        public syncobj_0x4631323442334233Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_TIME_ID, t.CHURCH_ID, t.ACTIVITY_ID, t.ACTIVITY_START_TIME, t.Created_Date, t.Created_By_Login });

            // Properties
            this.Property(t => t.ACTIVITY_TIME_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_TIME_NAME)
                .HasMaxLength(30);

            this.Property(t => t.Created_By_Login)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Last_Updated_By_Login)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4631323442334233");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_TIME_NAME).HasColumnName("ACTIVITY_TIME_NAME");
            this.Property(t => t.ACTIVITY_START_TIME).HasColumnName("ACTIVITY_START_TIME");
            this.Property(t => t.ACTIVITY_END_TIME).HasColumnName("ACTIVITY_END_TIME");
            this.Property(t => t.OLD_ACT_TIME_ID).HasColumnName("OLD_ACT_TIME_ID");
            this.Property(t => t.Created_Date).HasColumnName("Created_Date");
            this.Property(t => t.Created_By_User_ID).HasColumnName("Created_By_User_ID");
            this.Property(t => t.Created_By_Login).HasColumnName("Created_By_Login");
            this.Property(t => t.Last_Updated_Date).HasColumnName("Last_Updated_Date");
            this.Property(t => t.Last_Updated_By_Login).HasColumnName("Last_Updated_By_Login");
            this.Property(t => t.Last_Updated_By_User_ID).HasColumnName("Last_Updated_By_User_ID");
        }
    }
}
