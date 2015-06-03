using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class COMMONCCMap : EntityTypeConfiguration<COMMONCC>
    {
        public COMMONCCMap()
        {
            // Primary Key
            this.HasKey(t => t.CC_ID);

            // Properties
            this.Property(t => t.CC_NO)
                .HasMaxLength(60);

            this.Property(t => t.CC_NAME)
                .HasMaxLength(30);

            this.Property(t => t.CC_ADD1)
                .HasMaxLength(60);

            this.Property(t => t.CC_ADD2)
                .HasMaxLength(60);

            this.Property(t => t.CC_CITY)
                .HasMaxLength(30);

            this.Property(t => t.CC_STATE)
                .HasMaxLength(20);

            this.Property(t => t.CC_POSTAL_CODE)
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.CC_ADD3)
                .HasMaxLength(60);

            this.Property(t => t.CC_COUNTRY)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("COMMONCC");
            this.Property(t => t.CC_ID).HasColumnName("CC_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.CC_TYPE).HasColumnName("CC_TYPE");
            this.Property(t => t.CC_NO).HasColumnName("CC_NO");
            this.Property(t => t.CC_DATE).HasColumnName("CC_DATE");
            this.Property(t => t.CC_NAME).HasColumnName("CC_NAME");
            this.Property(t => t.CC_ADD1).HasColumnName("CC_ADD1");
            this.Property(t => t.CC_ADD2).HasColumnName("CC_ADD2");
            this.Property(t => t.CC_CITY).HasColumnName("CC_CITY");
            this.Property(t => t.CC_STATE).HasColumnName("CC_STATE");
            this.Property(t => t.CC_POSTAL_CODE).HasColumnName("CC_POSTAL_CODE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.CC_ADD3).HasColumnName("CC_ADD3");
            this.Property(t => t.CC_COUNTRY).HasColumnName("CC_COUNTRY");
        }
    }
}
