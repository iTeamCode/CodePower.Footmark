using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class COMMONCHECKMap : EntityTypeConfiguration<COMMONCHECK>
    {
        public COMMONCHECKMap()
        {
            // Primary Key
            this.HasKey(t => t.CHECK_ID);

            // Properties
            this.Property(t => t.CHECK_ROUTING_NUMBER)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.CHECK_ACCOUNT_NUMBER)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CHECK_NAME)
                .HasMaxLength(30);

            this.Property(t => t.CHECK_ADD1)
                .HasMaxLength(60);

            this.Property(t => t.CHECK_ADD2)
                .HasMaxLength(60);

            this.Property(t => t.CHECK_CITY)
                .HasMaxLength(30);

            this.Property(t => t.CHECK_STATE)
                .HasMaxLength(20);

            this.Property(t => t.CHECK_POSTAL_CODE)
                .HasMaxLength(20);

            this.Property(t => t.CHECK_PHONE)
                .HasMaxLength(20);

            this.Property(t => t.CHECK_BANK_NAME)
                .HasMaxLength(400);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.CHECK_ADD3)
                .HasMaxLength(60);

            this.Property(t => t.CHECK_COUNTRY)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("COMMONCHECK");
            this.Property(t => t.CHECK_ID).HasColumnName("CHECK_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.CHECK_ROUTING_NUMBER).HasColumnName("CHECK_ROUTING_NUMBER");
            this.Property(t => t.CHECK_ACCOUNT_NUMBER).HasColumnName("CHECK_ACCOUNT_NUMBER");
            this.Property(t => t.CHECK_NAME).HasColumnName("CHECK_NAME");
            this.Property(t => t.CHECK_ADD1).HasColumnName("CHECK_ADD1");
            this.Property(t => t.CHECK_ADD2).HasColumnName("CHECK_ADD2");
            this.Property(t => t.CHECK_CITY).HasColumnName("CHECK_CITY");
            this.Property(t => t.CHECK_STATE).HasColumnName("CHECK_STATE");
            this.Property(t => t.CHECK_POSTAL_CODE).HasColumnName("CHECK_POSTAL_CODE");
            this.Property(t => t.CHECK_PHONE).HasColumnName("CHECK_PHONE");
            this.Property(t => t.LAST_REGISTRATION).HasColumnName("LAST_REGISTRATION");
            this.Property(t => t.CHECK_BANK_NAME).HasColumnName("CHECK_BANK_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.CHECK_ADD3).HasColumnName("CHECK_ADD3");
            this.Property(t => t.CHECK_COUNTRY).HasColumnName("CHECK_COUNTRY");
        }
    }
}
