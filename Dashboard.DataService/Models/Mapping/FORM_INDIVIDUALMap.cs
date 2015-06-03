using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_INDIVIDUALMap : EntityTypeConfiguration<FORM_INDIVIDUAL>
    {
        public FORM_INDIVIDUALMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_INDIVIDUAL_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_INDIVIDUAL");
            this.Property(t => t.FORM_INDIVIDUAL_ID).HasColumnName("FORM_INDIVIDUAL_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.FORM_ID).HasColumnName("FORM_ID");
            this.Property(t => t.FORM_INDIVIDUAL_SET_ID).HasColumnName("FORM_INDIVIDUAL_SET_ID");
            this.Property(t => t.FORM_INDIVIDUAL_STATUS_TYPE_ID).HasColumnName("FORM_INDIVIDUAL_STATUS_TYPE_ID");
            this.Property(t => t.SUBMIT_DATE).HasColumnName("SUBMIT_DATE");
            this.Property(t => t.PAY_ORDER_ID).HasColumnName("PAY_ORDER_ID");
            this.Property(t => t.IS_DELETED).HasColumnName("IS_DELETED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.FORM)
                .WithMany(t => t.FORM_INDIVIDUAL)
                .HasForeignKey(d => d.FORM_ID);
            this.HasRequired(t => t.FORM_INDIVIDUAL_SET)
                .WithMany(t => t.FORM_INDIVIDUAL)
                .HasForeignKey(d => d.FORM_INDIVIDUAL_SET_ID);
            this.HasRequired(t => t.FORM_INDIVIDUAL_STATUS_TYPE)
                .WithMany(t => t.FORM_INDIVIDUAL)
                .HasForeignKey(d => d.FORM_INDIVIDUAL_STATUS_TYPE_ID);
            this.HasOptional(t => t.PAY_ORDER)
                .WithMany(t => t.FORM_INDIVIDUAL)
                .HasForeignKey(d => d.PAY_ORDER_ID);

        }
    }
}
