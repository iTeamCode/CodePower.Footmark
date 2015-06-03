using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_TIMEMap : EntityTypeConfiguration<ACTIVITY_TIME>
    {
        public ACTIVITY_TIMEMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_TIME_ID);

            // Properties
            this.Property(t => t.ACTIVITY_TIME_NAME)
                .HasMaxLength(30);

            this.Property(t => t.Created_By_Login)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Last_Updated_By_Login)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_TIME");
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
            this.Property(t => t.Max_End_Date).HasColumnName("Max_End_Date");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.ACTIVITY_TIME)
                .HasForeignKey(d => d.ACTIVITY_ID);

        }
    }
}
