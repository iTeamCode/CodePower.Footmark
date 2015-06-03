using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class PAY_ITEM_FORMMap : EntityTypeConfiguration<PAY_ITEM_FORM>
    {
        public PAY_ITEM_FORMMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PAY_ITEM_ID, t.FORM_ID });

            // Properties
            this.Property(t => t.PAY_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FORM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PAY_ITEM_FORM");
            this.Property(t => t.PAY_ITEM_ID).HasColumnName("PAY_ITEM_ID");
            this.Property(t => t.FORM_ID).HasColumnName("FORM_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");

            // Relationships
            this.HasRequired(t => t.FORM)
                .WithMany(t => t.PAY_ITEM_FORM)
                .HasForeignKey(d => d.FORM_ID);
            this.HasRequired(t => t.PAY_ITEM)
                .WithMany(t => t.PAY_ITEM_FORM)
                .HasForeignKey(d => d.PAY_ITEM_ID);

        }
    }
}
