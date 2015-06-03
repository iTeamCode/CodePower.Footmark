using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class PAY_TRANSACTION_STATUS_TYPEMap : EntityTypeConfiguration<PAY_TRANSACTION_STATUS_TYPE>
    {
        public PAY_TRANSACTION_STATUS_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.PAY_TRANSACTION_STATUS_TYPE_ID);

            // Properties
            this.Property(t => t.PAY_TRANSACTION_STATUS_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAY_TRANSACTION_STATUS_NAME)
                .HasMaxLength(30);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PAY_TRANSACTION_STATUS_TYPE");
            this.Property(t => t.PAY_TRANSACTION_STATUS_TYPE_ID).HasColumnName("PAY_TRANSACTION_STATUS_TYPE_ID");
            this.Property(t => t.PAY_TRANSACTION_STATUS_NAME).HasColumnName("PAY_TRANSACTION_STATUS_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
