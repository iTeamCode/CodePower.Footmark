using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class REGISTRATION_ACTIVITY_DETAILMap : EntityTypeConfiguration<REGISTRATION_ACTIVITY_DETAIL>
    {
        public REGISTRATION_ACTIVITY_DETAILMap()
        {
            // Primary Key
            this.HasKey(t => new { t.REGISTRATION_ITEM_ID, t.ACTIVITY_DETAIL_ID });

            // Properties
            this.Property(t => t.REGISTRATION_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("REGISTRATION_ACTIVITY_DETAIL");
            this.Property(t => t.REGISTRATION_ITEM_ID).HasColumnName("REGISTRATION_ITEM_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.ACTIVITY_REGISTRATION_ID).HasColumnName("ACTIVITY_REGISTRATION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.MAX_REGISTRATIONS).HasColumnName("MAX_REGISTRATIONS");
            this.Property(t => t.IS_DEFAULT).HasColumnName("IS_DEFAULT");
            this.Property(t => t.ENABLED).HasColumnName("ENABLED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.REGISTRATION_ACTIVITY_DETAIL)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasRequired(t => t.ACTIVITY_REGISTRATION)
                .WithMany(t => t.REGISTRATION_ACTIVITY_DETAIL)
                .HasForeignKey(d => d.ACTIVITY_REGISTRATION_ID);
            this.HasRequired(t => t.REGISTRATION_ITEM)
                .WithMany(t => t.REGISTRATION_ACTIVITY_DETAIL)
                .HasForeignKey(d => d.REGISTRATION_ITEM_ID);

        }
    }
}
