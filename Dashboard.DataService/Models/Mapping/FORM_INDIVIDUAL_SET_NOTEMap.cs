using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_INDIVIDUAL_SET_NOTEMap : EntityTypeConfiguration<FORM_INDIVIDUAL_SET_NOTE>
    {
        public FORM_INDIVIDUAL_SET_NOTEMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_INDIVIDUAL_SET_NOTE_ID);

            // Properties
            this.Property(t => t.NOTE_TEXT)
                .IsRequired();

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_INDIVIDUAL_SET_NOTE");
            this.Property(t => t.FORM_INDIVIDUAL_SET_NOTE_ID).HasColumnName("FORM_INDIVIDUAL_SET_NOTE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.NOTE_ID).HasColumnName("NOTE_ID");
            this.Property(t => t.NOTE_TEXT).HasColumnName("NOTE_TEXT");
            this.Property(t => t.FORM_INDIVIDUAL_SET_ID).HasColumnName("FORM_INDIVIDUAL_SET_ID");
            this.Property(t => t.ARCHIVED).HasColumnName("ARCHIVED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.FORM_INDIVIDUAL_SET)
                .WithMany(t => t.FORM_INDIVIDUAL_SET_NOTE)
                .HasForeignKey(d => d.FORM_INDIVIDUAL_SET_ID);

        }
    }
}
