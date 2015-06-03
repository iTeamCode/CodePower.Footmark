using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_PROPERTYMap : EntityTypeConfiguration<ACTIVITY_PROPERTY>
    {
        public ACTIVITY_PROPERTYMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_PROPERTY_ID);

            // Properties
            this.Property(t => t.ACTIVITY_PROPERTY_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_PROPERTY");
            this.Property(t => t.ACTIVITY_PROPERTY_ID).HasColumnName("ACTIVITY_PROPERTY_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_PROPERTY_NAME).HasColumnName("ACTIVITY_PROPERTY_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.IS_FILTER_CHOICE).HasColumnName("IS_FILTER_CHOICE");
            this.Property(t => t.SHOW_RESULTS).HasColumnName("SHOW_RESULTS");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.ACTIVITY_PROPERTY)
                .HasForeignKey(d => d.ACTIVITY_ID);

        }
    }
}
