using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_MINISTRYMap : EntityTypeConfiguration<ACTIVITY_MINISTRY>
    {
        public ACTIVITY_MINISTRYMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MINISTRY_ID, t.ACTIVITY_ID });

            // Properties
            this.Property(t => t.MINISTRY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_MINISTRY");
            this.Property(t => t.MINISTRY_ID).HasColumnName("MINISTRY_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.IS_PRIMARY).HasColumnName("IS_PRIMARY");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.OLD_MIN_ID).HasColumnName("OLD_MIN_ID");
            this.Property(t => t.OLD_ACT_ID).HasColumnName("OLD_ACT_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.ACTIVITY_MINISTRY)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasRequired(t => t.MINISTRY)
                .WithMany(t => t.ACTIVITY_MINISTRY)
                .HasForeignKey(d => d.MINISTRY_ID);

        }
    }
}
