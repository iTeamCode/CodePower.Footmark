using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class FORM_ITEM_OPTION_INDIVIDUALMap : EntityTypeConfiguration<FORM_ITEM_OPTION_INDIVIDUAL>
    {
        public FORM_ITEM_OPTION_INDIVIDUALMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FORM_INDIVIDUAL_ID, t.FORM_ITEM_ID });

            // Properties
            this.Property(t => t.FORM_INDIVIDUAL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FORM_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FORM_ITEM_OPTION_INDIVIDUAL");
            this.Property(t => t.FORM_INDIVIDUAL_ID).HasColumnName("FORM_INDIVIDUAL_ID");
            this.Property(t => t.FORM_ITEM_ID).HasColumnName("FORM_ITEM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.FORM_ITEM_OPTION_ID).HasColumnName("FORM_ITEM_OPTION_ID");
            this.Property(t => t.INDIVIDUAL_PREF_ID).HasColumnName("INDIVIDUAL_PREF_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.FORM_INDIVIDUAL)
                .WithMany(t => t.FORM_ITEM_OPTION_INDIVIDUAL)
                .HasForeignKey(d => d.FORM_INDIVIDUAL_ID);
            this.HasRequired(t => t.FORM_ITEM)
                .WithMany(t => t.FORM_ITEM_OPTION_INDIVIDUAL)
                .HasForeignKey(d => d.FORM_ITEM_ID);
            this.HasOptional(t => t.FORM_ITEM_OPTION)
                .WithMany(t => t.FORM_ITEM_OPTION_INDIVIDUAL)
                .HasForeignKey(d => d.FORM_ITEM_OPTION_ID);
            this.HasOptional(t => t.INDIVIDUAL_PREFS)
                .WithMany(t => t.FORM_ITEM_OPTION_INDIVIDUAL)
                .HasForeignKey(d => d.INDIVIDUAL_PREF_ID);

        }
    }
}
