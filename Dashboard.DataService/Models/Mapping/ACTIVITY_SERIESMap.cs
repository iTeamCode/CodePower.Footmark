using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_SERIESMap : EntityTypeConfiguration<ACTIVITY_SERIES>
    {
        public ACTIVITY_SERIESMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_SERIES_ID);

            // Properties
            this.Property(t => t.ACTIVITY_SERIES_NAME)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_SERIES");
            this.Property(t => t.ACTIVITY_SERIES_ID).HasColumnName("ACTIVITY_SERIES_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_SERIES_NAME).HasColumnName("ACTIVITY_SERIES_NAME");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.SERIES_START_DATE).HasColumnName("SERIES_START_DATE");
            this.Property(t => t.SERIES_END_DATE).HasColumnName("SERIES_END_DATE");
            this.Property(t => t.SERIES_TOPIC_ID).HasColumnName("SERIES_TOPIC_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.ACTIVITY_SERIES)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasOptional(t => t.SERIES_TOPIC)
                .WithMany(t => t.ACTIVITY_SERIES)
                .HasForeignKey(d => d.SERIES_TOPIC_ID);

        }
    }
}
