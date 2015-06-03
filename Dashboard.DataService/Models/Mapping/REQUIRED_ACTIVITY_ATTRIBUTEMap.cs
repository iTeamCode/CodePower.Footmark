using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REQUIRED_ACTIVITY_ATTRIBUTEMap : EntityTypeConfiguration<REQUIRED_ACTIVITY_ATTRIBUTE>
    {
        public REQUIRED_ACTIVITY_ATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_ID, t.ACTIVITY_ATTRIBUTE_ID });

            // Properties
            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ATTRIBUTE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REQUIRED_ACTIVITY_ATTRIBUTE");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_ATTRIBUTE_ID).HasColumnName("ACTIVITY_ATTRIBUTE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.OLD_ACT_ID).HasColumnName("OLD_ACT_ID");
            this.Property(t => t.OLD_ACT_ATTR_ID).HasColumnName("OLD_ACT_ATTR_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.REQUIRED_ACTIVITY_ATTRIBUTE)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasRequired(t => t.ACTIVITY_ATTRIBUTE)
                .WithMany(t => t.REQUIRED_ACTIVITY_ATTRIBUTE)
                .HasForeignKey(d => d.ACTIVITY_ATTRIBUTE_ID);

        }
    }
}