using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class VOLUNTEER_OPPORTUNITY_REFERENCE_ITEMMap : EntityTypeConfiguration<VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM>
    {
        public VOLUNTEER_OPPORTUNITY_REFERENCE_ITEMMap()
        {
            // Primary Key
            this.HasKey(t => new { t.REFERENCE_QUESTION_ID, t.VOLUNTEER_OPPORTUNITY_ID });

            // Properties
            this.Property(t => t.REFERENCE_QUESTION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VOLUNTEER_OPPORTUNITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM");
            this.Property(t => t.REFERENCE_QUESTION_ID).HasColumnName("REFERENCE_QUESTION_ID");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.REFERENCE_QUESTION)
                .WithMany(t => t.VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM)
                .HasForeignKey(d => d.REFERENCE_QUESTION_ID);
            this.HasRequired(t => t.VOLUNTEER_OPPORTUNITY)
                .WithMany(t => t.VOLUNTEER_OPPORTUNITY_REFERENCE_ITEM)
                .HasForeignKey(d => d.VOLUNTEER_OPPORTUNITY_ID);

        }
    }
}
