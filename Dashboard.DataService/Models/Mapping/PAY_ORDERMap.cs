using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class PAY_ORDERMap : EntityTypeConfiguration<PAY_ORDER>
    {
        public PAY_ORDERMap()
        {
            // Primary Key
            this.HasKey(t => t.PAY_ORDER_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PAY_ORDER");
            this.Property(t => t.PAY_ORDER_ID).HasColumnName("PAY_ORDER_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.PAY_ORDER_SET_ID).HasColumnName("PAY_ORDER_SET_ID");
            this.Property(t => t.UNADJUSTED_AMOUNT).HasColumnName("UNADJUSTED_AMOUNT");
            this.Property(t => t.TOTAL_AMOUNT).HasColumnName("TOTAL_AMOUNT");
            this.Property(t => t.PAY_ORDER_STATUS_TYPE_ID).HasColumnName("PAY_ORDER_STATUS_TYPE_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.PAY_ORDER_SET)
                .WithMany(t => t.PAY_ORDER)
                .HasForeignKey(d => d.PAY_ORDER_SET_ID);
            this.HasRequired(t => t.PAY_ORDER_STATUS_TYPE)
                .WithMany(t => t.PAY_ORDER)
                .HasForeignKey(d => d.PAY_ORDER_STATUS_TYPE_ID);

        }
    }
}
