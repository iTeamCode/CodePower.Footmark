using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REFERENCE_ITEM_LOVMap : EntityTypeConfiguration<REFERENCE_ITEM_LOV>
    {
        public REFERENCE_ITEM_LOVMap()
        {
            // Primary Key
            this.HasKey(t => t.REFERENCE_ITEM_LOV_ID);

            // Properties
            this.Property(t => t.DESCRIPTION)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REFERENCE_ITEM_LOV");
            this.Property(t => t.REFERENCE_ITEM_LOV_ID).HasColumnName("REFERENCE_ITEM_LOV_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.REFERENCE_QUESTION_ID).HasColumnName("REFERENCE_QUESTION_ID");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.REFERENCE_QUESTION)
                .WithMany(t => t.REFERENCE_ITEM_LOV)
                .HasForeignKey(d => d.REFERENCE_QUESTION_ID);

        }
    }
}
