using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_CUSTOM_REGISTRATIONMap : EntityTypeConfiguration<INDIVIDUAL_CUSTOM_REGISTRATION>
    {
        public INDIVIDUAL_CUSTOM_REGISTRATIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.INDIVIDUAL_REGISTRATION_ID, t.REGISTRATION_CUSTOM_ID, t.ACTIVITY_ID });

            // Properties
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_CUSTOM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CUSTOM_VALUE)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_CUSTOM_REGISTRATION");
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID).HasColumnName("INDIVIDUAL_REGISTRATION_ID");
            this.Property(t => t.REGISTRATION_CUSTOM_ID).HasColumnName("REGISTRATION_CUSTOM_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.CUSTOM_VALUE).HasColumnName("CUSTOM_VALUE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.INDIVIDUAL_CUSTOM_REGISTRATION)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasRequired(t => t.REGISTRATION_CUSTOM)
                .WithMany(t => t.INDIVIDUAL_CUSTOM_REGISTRATION)
                .HasForeignKey(d => d.REGISTRATION_CUSTOM_ID);

        }
    }
}
