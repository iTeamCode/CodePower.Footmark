using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3846463245364430Map : EntityTypeConfiguration<syncobj_0x3846463245364430>
    {
        public syncobj_0x3846463245364430Map()
        {
            // Primary Key
            this.HasKey(t => new { t.PAY_ORDER_STATUS_TYPE_ID, t.ORDER_STATUS_TYPE_NAME });

            // Properties
            this.Property(t => t.PAY_ORDER_STATUS_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ORDER_STATUS_TYPE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3846463245364430");
            this.Property(t => t.PAY_ORDER_STATUS_TYPE_ID).HasColumnName("PAY_ORDER_STATUS_TYPE_ID");
            this.Property(t => t.ORDER_STATUS_TYPE_NAME).HasColumnName("ORDER_STATUS_TYPE_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}