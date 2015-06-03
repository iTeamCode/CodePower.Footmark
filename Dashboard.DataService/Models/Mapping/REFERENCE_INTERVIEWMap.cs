using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REFERENCE_INTERVIEWMap : EntityTypeConfiguration<REFERENCE_INTERVIEW>
    {
        public REFERENCE_INTERVIEWMap()
        {
            // Primary Key
            this.HasKey(t => new { t.REFERENCE_ID, t.REFERENCE_QUESTION_ID });

            // Properties
            this.Property(t => t.REFERENCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REFERENCE_QUESTION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRIPTION)
                .IsRequired();

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REFERENCE_INTERVIEW");
            this.Property(t => t.REFERENCE_ID).HasColumnName("REFERENCE_ID");
            this.Property(t => t.REFERENCE_QUESTION_ID).HasColumnName("REFERENCE_QUESTION_ID");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.REFERENCE_INSTANCE_ID).HasColumnName("REFERENCE_INSTANCE_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.REFERENCE)
                .WithMany(t => t.REFERENCE_INTERVIEW)
                .HasForeignKey(d => d.REFERENCE_ID);
            this.HasRequired(t => t.REFERENCE_INSTANCE)
                .WithMany(t => t.REFERENCE_INTERVIEW)
                .HasForeignKey(d => d.REFERENCE_INSTANCE_ID);
            this.HasRequired(t => t.REFERENCE_QUESTION)
                .WithMany(t => t.REFERENCE_INTERVIEW)
                .HasForeignKey(d => d.REFERENCE_QUESTION_ID);

        }
    }
}
