using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_PROPERTY_ACTIVITY_DETAILMap : EntityTypeConfiguration<ACTIVITY_PROPERTY_ACTIVITY_DETAIL>
    {
        public ACTIVITY_PROPERTY_ACTIVITY_DETAILMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_PROPERTY_LOV_ID, t.ACTIVITY_DETAIL_ID });

            // Properties
            this.Property(t => t.ACTIVITY_PROPERTY_LOV_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_PROPERTY_ACTIVITY_DETAIL");
            this.Property(t => t.ACTIVITY_PROPERTY_LOV_ID).HasColumnName("ACTIVITY_PROPERTY_LOV_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.ACTIVITY_PROPERTY_ACTIVITY_DETAIL)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasRequired(t => t.ACTIVITY_PROPERTY_LOV)
                .WithMany(t => t.ACTIVITY_PROPERTY_ACTIVITY_DETAIL)
                .HasForeignKey(d => d.ACTIVITY_PROPERTY_LOV_ID);

        }
    }
}
