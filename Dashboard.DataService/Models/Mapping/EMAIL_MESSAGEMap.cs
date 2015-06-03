using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class EMAIL_MESSAGEMap : EntityTypeConfiguration<EMAIL_MESSAGE>
    {
        public EMAIL_MESSAGEMap()
        {
            // Primary Key
            this.HasKey(t => t.EMAIL_MESSAGE_ID);

            // Properties
            this.Property(t => t.FROM_ADDRESS)
                .HasMaxLength(50);

            this.Property(t => t.CC_LIST)
                .HasMaxLength(500);

            this.Property(t => t.BCC_LIST)
                .HasMaxLength(500);

            this.Property(t => t.SUBJECT)
                .HasMaxLength(50);

            this.Property(t => t.BODY)
                .HasMaxLength(6000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("EMAIL_MESSAGE");
            this.Property(t => t.EMAIL_MESSAGE_ID).HasColumnName("EMAIL_MESSAGE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.FROM_ADDRESS).HasColumnName("FROM_ADDRESS");
            this.Property(t => t.CC_LIST).HasColumnName("CC_LIST");
            this.Property(t => t.BCC_LIST).HasColumnName("BCC_LIST");
            this.Property(t => t.SUBJECT).HasColumnName("SUBJECT");
            this.Property(t => t.BODY).HasColumnName("BODY");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.DELETED_DATE).HasColumnName("DELETED_DATE");
            this.Property(t => t.DELETED_BY_USER_ID).HasColumnName("DELETED_BY_USER_ID");
        }
    }
}
