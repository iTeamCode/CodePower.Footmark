using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_REGISTRATION_ITEM_LOVMap : EntityTypeConfiguration<INDIVIDUAL_REGISTRATION_ITEM_LOV>
    {
        public INDIVIDUAL_REGISTRATION_ITEM_LOVMap()
        {
            // Primary Key
            this.HasKey(t => new { t.INDIVIDUAL_REGISTRATION_ID, t.REGISTRATION_ITEM_ID, t.REGISTRATION_ITEM_LOV });

            // Properties
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REGISTRATION_ITEM_LOV)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_REGISTRATION_ITEM_LOV");
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID).HasColumnName("INDIVIDUAL_REGISTRATION_ID");
            this.Property(t => t.REGISTRATION_ITEM_ID).HasColumnName("REGISTRATION_ITEM_ID");
            this.Property(t => t.REGISTRATION_ITEM_LOV).HasColumnName("REGISTRATION_ITEM_LOV");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.QUANTITY).HasColumnName("QUANTITY");
            this.Property(t => t.TOTAL_AMOUNT).HasColumnName("TOTAL_AMOUNT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.INDIVIDUAL_REGISTRATION_2)
                .WithMany(t => t.INDIVIDUAL_REGISTRATION_ITEM_LOV)
                .HasForeignKey(d => d.INDIVIDUAL_REGISTRATION_ID);
            this.HasRequired(t => t.REGISTRATION_ITEM)
                .WithMany(t => t.INDIVIDUAL_REGISTRATION_ITEM_LOV)
                .HasForeignKey(d => d.REGISTRATION_ITEM_ID);
            this.HasRequired(t => t.REGISTRATION_ITEM_LOV1)
                .WithMany(t => t.INDIVIDUAL_REGISTRATION_ITEM_LOV)
                .HasForeignKey(d => d.REGISTRATION_ITEM_LOV);

        }
    }
}