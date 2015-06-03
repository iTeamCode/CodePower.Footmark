using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_INDIVIDUAL_SETMap : EntityTypeConfiguration<FORM_INDIVIDUAL_SET>
    {
        public FORM_INDIVIDUAL_SETMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_INDIVIDUAL_SET_ID);

            // Properties
            this.Property(t => t.CONFIRMATION_CODE)
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_INDIVIDUAL_SET");
            this.Property(t => t.FORM_INDIVIDUAL_SET_ID).HasColumnName("FORM_INDIVIDUAL_SET_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.PAY_ORDER_SET_ID).HasColumnName("PAY_ORDER_SET_ID");
            this.Property(t => t.CONFIRMATION_CODE).HasColumnName("CONFIRMATION_CODE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasOptional(t => t.PAY_ORDER_SET)
                .WithMany(t => t.FORM_INDIVIDUAL_SET)
                .HasForeignKey(d => d.PAY_ORDER_SET_ID);

        }
    }
}
