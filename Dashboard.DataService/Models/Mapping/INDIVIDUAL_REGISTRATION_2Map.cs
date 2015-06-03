using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_REGISTRATION_2Map : EntityTypeConfiguration<INDIVIDUAL_REGISTRATION_2>
    {
        public INDIVIDUAL_REGISTRATION_2Map()
        {
            // Primary Key
            this.HasKey(t => t.INDIVIDUAL_REGISTRATION_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_REGISTRATION_2");
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID).HasColumnName("INDIVIDUAL_REGISTRATION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.REGISTRATION_INSTANCE_ID).HasColumnName("REGISTRATION_INSTANCE_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.CREATED).HasColumnName("CREATED");
            this.Property(t => t.MODIFIED).HasColumnName("MODIFIED");
            this.Property(t => t.IS_GLOBAL).HasColumnName("IS_GLOBAL");
            this.Property(t => t.CC_ID).HasColumnName("CC_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.REGISTRATION_STATUS_ID).HasColumnName("REGISTRATION_STATUS_ID");
            this.Property(t => t.CHECK_ID).HasColumnName("CHECK_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasOptional(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.INDIVIDUAL_REGISTRATION_2)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasOptional(t => t.REGISTRATION_INSTANCE)
                .WithMany(t => t.INDIVIDUAL_REGISTRATION_2)
                .HasForeignKey(d => d.REGISTRATION_INSTANCE_ID);
            this.HasOptional(t => t.REGISTRATION_STATUS)
                .WithMany(t => t.INDIVIDUAL_REGISTRATION_2)
                .HasForeignKey(d => d.REGISTRATION_STATUS_ID);

        }
    }
}
