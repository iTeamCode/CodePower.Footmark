using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORMMap : EntityTypeConfiguration<FORM>
    {
        public FORMMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_ID);

            // Properties
            this.Property(t => t.FORM_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FORM_CODE)
                .HasMaxLength(10);

            this.Property(t => t.GENDER_RESTRICTION)
                .HasMaxLength(10);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM");
            this.Property(t => t.FORM_ID).HasColumnName("FORM_ID");
            this.Property(t => t.FORM_TYPE_ID).HasColumnName("FORM_TYPE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.FORM_NAME).HasColumnName("FORM_NAME");
            this.Property(t => t.FORM_CODE).HasColumnName("FORM_CODE");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.START_DATE).HasColumnName("START_DATE");
            this.Property(t => t.END_DATE).HasColumnName("END_DATE");
            this.Property(t => t.MIN_AGE).HasColumnName("MIN_AGE");
            this.Property(t => t.MAX_AGE).HasColumnName("MAX_AGE");
            this.Property(t => t.MAX_CAPACITY).HasColumnName("MAX_CAPACITY");
            this.Property(t => t.AGE_UNIT_YEAR).HasColumnName("AGE_UNIT_YEAR");
            this.Property(t => t.AGE_CUTOFF_DATE).HasColumnName("AGE_CUTOFF_DATE");
            this.Property(t => t.GENDER_RESTRICTION).HasColumnName("GENDER_RESTRICTION");
            this.Property(t => t.FUND_ID).HasColumnName("FUND_ID");
            this.Property(t => t.SUB_FUND_ID).HasColumnName("SUB_FUND_ID");
            this.Property(t => t.CONTACT_ITEM_ID).HasColumnName("CONTACT_ITEM_ID");
            this.Property(t => t.CONFIRMATION_EMAIL_MESSAGE_ID).HasColumnName("CONFIRMATION_EMAIL_MESSAGE_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasOptional(t => t.EMAIL_MESSAGE)
                .WithMany(t => t.FORMs)
                .HasForeignKey(d => d.CONFIRMATION_EMAIL_MESSAGE_ID);
            this.HasRequired(t => t.FORM_TYPE)
                .WithMany(t => t.FORMs)
                .HasForeignKey(d => d.FORM_TYPE_ID);

        }
    }
}