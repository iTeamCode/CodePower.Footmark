using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3137394244323541Map : EntityTypeConfiguration<syncobj_0x3137394244323541>
    {
        public syncobj_0x3137394244323541Map()
        {
            // Primary Key
            this.HasKey(t => new { t.PROMOTION_CODE_ID, t.CHURCH_ID, t.ACTIVITY_REGISTRATION_ID, t.PROMOTION_CODE_NAME, t.PROMOTION_CODE, t.AUTO_GENERATED, t.IS_INDIVIDUAL, t.MULTIPLE_USE, t.HOUSEHOLD_ONLY, t.STAFF_ONLY, t.START_DATE, t.END_DATE, t.ENABLED });

            // Properties
            this.Property(t => t.PROMOTION_CODE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_REGISTRATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PROMOTION_CODE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PROMOTION_CODE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3137394244323541");
            this.Property(t => t.PROMOTION_CODE_ID).HasColumnName("PROMOTION_CODE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.PROMOTION_CODE_NAME).HasColumnName("PROMOTION_CODE_NAME");
            this.Property(t => t.PROMOTION_CODE).HasColumnName("PROMOTION_CODE");
            this.Property(t => t.DISCOUNT_AMOUNT).HasColumnName("DISCOUNT_AMOUNT");
            this.Property(t => t.DISCOUNT_PERCENTAGE).HasColumnName("DISCOUNT_PERCENTAGE");
            this.Property(t => t.AUTO_GENERATED).HasColumnName("AUTO_GENERATED");
            this.Property(t => t.IS_INDIVIDUAL).HasColumnName("IS_INDIVIDUAL");
            this.Property(t => t.MULTIPLE_USE).HasColumnName("MULTIPLE_USE");
            this.Property(t => t.HOUSEHOLD_ONLY).HasColumnName("HOUSEHOLD_ONLY");
            this.Property(t => t.STAFF_ONLY).HasColumnName("STAFF_ONLY");
            this.Property(t => t.START_DATE).HasColumnName("START_DATE");
            this.Property(t => t.END_DATE).HasColumnName("END_DATE");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
