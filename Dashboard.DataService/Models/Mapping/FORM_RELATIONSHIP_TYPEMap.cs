using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_RELATIONSHIP_TYPEMap : EntityTypeConfiguration<FORM_RELATIONSHIP_TYPE>
    {
        public FORM_RELATIONSHIP_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_RELATIONSHIP_TYPE_ID);

            // Properties
            this.Property(t => t.FORM_RELATIONSHIP_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FORM_RELATIONSHIP_TYPE_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_RELATIONSHIP_TYPE");
            this.Property(t => t.FORM_RELATIONSHIP_TYPE_ID).HasColumnName("FORM_RELATIONSHIP_TYPE_ID");
            this.Property(t => t.FORM_RELATIONSHIP_TYPE_NAME).HasColumnName("FORM_RELATIONSHIP_TYPE_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
