using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3530374342434137Map : EntityTypeConfiguration<syncobj_0x3530374342434137>
    {
        public syncobj_0x3530374342434137Map()
        {
            // Primary Key
            this.HasKey(t => new { t.PAY_ORDER_SET_ID, t.CHURCH_ID, t.INDIVIDUAL_ID, t.AMOUNT, t.UNADJUSTED_AMOUNT });

            // Properties
            this.Property(t => t.PAY_ORDER_SET_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AMOUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PP_REQUEST_CODE)
                .HasMaxLength(26);

            this.Property(t => t.PAYMENT_DESCRIPTION)
                .HasMaxLength(100);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.UNADJUSTED_AMOUNT)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3530374342434137");
            this.Property(t => t.PAY_ORDER_SET_ID).HasColumnName("PAY_ORDER_SET_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.AMOUNT).HasColumnName("AMOUNT");
            this.Property(t => t.PP_REQUEST_CODE).HasColumnName("PP_REQUEST_CODE");
            this.Property(t => t.PAYMENT_DESCRIPTION).HasColumnName("PAYMENT_DESCRIPTION");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.UNADJUSTED_AMOUNT).HasColumnName("UNADJUSTED_AMOUNT");
        }
    }
}
