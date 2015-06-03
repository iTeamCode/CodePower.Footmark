using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class VISITORMap : EntityTypeConfiguration<VISITOR>
    {
        public VISITORMap()
        {
            // Primary Key
            this.HasKey(t => t.VISITOR_ID);

            // Properties
            this.Property(t => t.LAST_NAME)
                .HasMaxLength(30);

            this.Property(t => t.FIRST_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VISITOR");
            this.Property(t => t.VISITOR_ID).HasColumnName("VISITOR_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.LAST_NAME).HasColumnName("LAST_NAME");
            this.Property(t => t.FIRST_NAME).HasColumnName("FIRST_NAME");
            this.Property(t => t.VISITOR_DATE).HasColumnName("VISITOR_DATE");
            this.Property(t => t.DATE_OF_BIRTH).HasColumnName("DATE_OF_BIRTH");
            this.Property(t => t.HOUSEHOLD_ID).HasColumnName("HOUSEHOLD_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
