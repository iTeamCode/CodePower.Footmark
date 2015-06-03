using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_RELATIONSHIPMap : EntityTypeConfiguration<FORM_RELATIONSHIP>
    {
        public FORM_RELATIONSHIPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FORM1_ID, t.FORM2_ID });

            // Properties
            this.Property(t => t.FORM1_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FORM2_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_RELATIONSHIP");
            this.Property(t => t.FORM1_ID).HasColumnName("FORM1_ID");
            this.Property(t => t.FORM2_ID).HasColumnName("FORM2_ID");
            this.Property(t => t.FORM_RELATIONSHIP_TYPE_ID).HasColumnName("FORM_RELATIONSHIP_TYPE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.FORM)
                .WithMany(t => t.FORM_RELATIONSHIP)
                .HasForeignKey(d => d.FORM1_ID);
            this.HasRequired(t => t.FORM1)
                .WithMany(t => t.FORM_RELATIONSHIP1)
                .HasForeignKey(d => d.FORM2_ID);
            this.HasRequired(t => t.FORM_RELATIONSHIP_TYPE)
                .WithMany(t => t.FORM_RELATIONSHIP)
                .HasForeignKey(d => d.FORM_RELATIONSHIP_TYPE_ID);

        }
    }
}
