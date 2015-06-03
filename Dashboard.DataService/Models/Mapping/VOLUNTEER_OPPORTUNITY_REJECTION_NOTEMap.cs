using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class VOLUNTEER_OPPORTUNITY_REJECTION_NOTEMap : EntityTypeConfiguration<VOLUNTEER_OPPORTUNITY_REJECTION_NOTE>
    {
        public VOLUNTEER_OPPORTUNITY_REJECTION_NOTEMap()
        {
            // Primary Key
            this.HasKey(t => t.VOLUNTEER_OPPORTUNITY_REJECTION_NOTE_ID);

            // Properties
            this.Property(t => t.REJECTION_NOTE)
                .IsRequired();

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VOLUNTEER_OPPORTUNITY_REJECTION_NOTE");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_REJECTION_NOTE_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_REJECTION_NOTE_ID");
            this.Property(t => t.REJECTION_NOTE).HasColumnName("REJECTION_NOTE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
