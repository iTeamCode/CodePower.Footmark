using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class PAY_TRANSACTIONMap : EntityTypeConfiguration<PAY_TRANSACTION>
    {
        public PAY_TRANSACTIONMap()
        {
            // Primary Key
            this.HasKey(t => t.PAY_TRANSACTION_ID);

            // Properties
            this.Property(t => t.PP_REQUEST_CODE)
                .HasMaxLength(50);

            this.Property(t => t.PAYMENT_DESCRIPTION)
                .HasMaxLength(100);

            this.Property(t => t.MEMO)
                .HasMaxLength(300);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PAY_TRANSACTION");
            this.Property(t => t.PAY_TRANSACTION_ID).HasColumnName("PAY_TRANSACTION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.PAY_TRANSACTION_TYPE_ID).HasColumnName("PAY_TRANSACTION_TYPE_ID");
            this.Property(t => t.PAY_TRANSACTION_STATUS_TYPE_ID).HasColumnName("PAY_TRANSACTION_STATUS_TYPE_ID");
            this.Property(t => t.PP_REQUEST_CODE).HasColumnName("PP_REQUEST_CODE");
            this.Property(t => t.PP_REQUEST_ID).HasColumnName("PP_REQUEST_ID");
            this.Property(t => t.AMOUNT).HasColumnName("AMOUNT");
            this.Property(t => t.TRANSACTION_DATE).HasColumnName("TRANSACTION_DATE");
            this.Property(t => t.PAYMENT_DESCRIPTION).HasColumnName("PAYMENT_DESCRIPTION");
            this.Property(t => t.MEMO).HasColumnName("MEMO");
            this.Property(t => t.PAY_ORDER_SET_ID).HasColumnName("PAY_ORDER_SET_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.PAY_ORDER_SET)
                .WithMany(t => t.PAY_TRANSACTION)
                .HasForeignKey(d => d.PAY_ORDER_SET_ID);
            this.HasRequired(t => t.PAY_TRANSACTION_STATUS_TYPE)
                .WithMany(t => t.PAY_TRANSACTION)
                .HasForeignKey(d => d.PAY_TRANSACTION_STATUS_TYPE_ID);
            this.HasRequired(t => t.PAY_TRANSACTION_TYPE)
                .WithMany(t => t.PAY_TRANSACTION)
                .HasForeignKey(d => d.PAY_TRANSACTION_TYPE_ID);

        }
    }
}
