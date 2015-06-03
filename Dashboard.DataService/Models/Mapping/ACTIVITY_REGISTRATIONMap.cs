using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_REGISTRATIONMap : EntityTypeConfiguration<ACTIVITY_REGISTRATION>
    {
        public ACTIVITY_REGISTRATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_REGISTRATION_ID);

            // Properties
            this.Property(t => t.ACTIVITY_REGISTRATION_NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FORM_CODE)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.COMPLETION_REDIRECT_URL)
                .HasMaxLength(300);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_REGISTRATION");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_NAME).HasColumnName("ACTIVITY_REGISTRATION_NAME");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.REGISTER_DETAIL_BY).HasColumnName("REGISTER_DETAIL_BY");
            this.Property(t => t.START_DATE_TIME).HasColumnName("START_DATE_TIME");
            this.Property(t => t.END_DATE_TIME).HasColumnName("END_DATE_TIME");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
            this.Property(t => t.FORM_CODE).HasColumnName("FORM_CODE");
            this.Property(t => t.EMAIL_CONFIRMATION).HasColumnName("EMAIL_CONFIRMATION");
            this.Property(t => t.CONFIRMATION_MESSAGE).HasColumnName("CONFIRMATION_MESSAGE");
            this.Property(t => t.COMPLETION_REDIRECT_URL).HasColumnName("COMPLETION_REDIRECT_URL");
            this.Property(t => t.RESTRICT_AGE).HasColumnName("RESTRICT_AGE");
            this.Property(t => t.IS_VOLUNTEER).HasColumnName("IS_VOLUNTEER");
            this.Property(t => t.AUTO_FEED_PREFS).HasColumnName("AUTO_FEED_PREFS");
            this.Property(t => t.AGE_CUTOFF_DATE).HasColumnName("AGE_CUTOFF_DATE");
            this.Property(t => t.MERCHANT_ACCOUNT_ID).HasColumnName("MERCHANT_ACCOUNT_ID");
            this.Property(t => t.CONTACT_ITEM_ID).HasColumnName("CONTACT_ITEM_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.ACTIVITY_REGISTRATION)
                .HasForeignKey(d => d.ACTIVITY_ID);

        }
    }
}