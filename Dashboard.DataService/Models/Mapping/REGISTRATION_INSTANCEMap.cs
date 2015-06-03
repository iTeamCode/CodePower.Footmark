using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_INSTANCEMap : EntityTypeConfiguration<REGISTRATION_INSTANCE>
    {
        public REGISTRATION_INSTANCEMap()
        {
            // Primary Key
            this.HasKey(t => t.REGISTRATION_INSTANCE_ID);

            // Properties
            this.Property(t => t.EMAIL)
                .HasMaxLength(100);

            this.Property(t => t.CONFIRMATION_CODE)
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_INSTANCE");
            this.Property(t => t.REGISTRATION_INSTANCE_ID).HasColumnName("REGISTRATION_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.CONFIRMATION_CODE).HasColumnName("CONFIRMATION_CODE");
            this.Property(t => t.CREATED).HasColumnName("CREATED");
            this.Property(t => t.MODIFIED).HasColumnName("MODIFIED");
            this.Property(t => t.COMPANY_ID).HasColumnName("COMPANY_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_PARENT_ID).HasColumnName("ACTIVITY_REGISTRATION_PARENT_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_REGISTRATION)
                .WithMany(t => t.REGISTRATION_INSTANCE)
                .HasForeignKey(d => d.ACTIVITY_REGISTRATION_ID);

        }
    }
}
