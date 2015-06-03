using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class RG_ACTIVITY_REGISTRATIONMap : EntityTypeConfiguration<RG_ACTIVITY_REGISTRATION>
    {
        public RG_ACTIVITY_REGISTRATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.FORM_ID);

            // Properties
            this.Property(t => t.FORM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("RG_ACTIVITY_REGISTRATION");
            this.Property(t => t.FORM_ID).HasColumnName("FORM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.INDIVIDUAL_GROUP_ID).HasColumnName("INDIVIDUAL_GROUP_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.RG_ACTIVITY_REGISTRATION)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasOptional(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.RG_ACTIVITY_REGISTRATION)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasRequired(t => t.FORM)
                .WithOptional(t => t.RG_ACTIVITY_REGISTRATION);
            this.HasOptional(t => t.INDIVIDUAL_GROUP)
                .WithMany(t => t.RG_ACTIVITY_REGISTRATION)
                .HasForeignKey(d => d.INDIVIDUAL_GROUP_ID);

        }
    }
}
