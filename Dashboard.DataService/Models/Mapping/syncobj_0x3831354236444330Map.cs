using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3831354236444330Map : EntityTypeConfiguration<syncobj_0x3831354236444330>
    {
        public syncobj_0x3831354236444330Map()
        {
            // Primary Key
            this.HasKey(t => new { t.FORM_INDIVIDUAL_SET_NOTE_ID, t.CHURCH_ID, t.NOTE_ID, t.NOTE_TEXT, t.FORM_INDIVIDUAL_SET_ID, t.ARCHIVED, t.CREATED_DATE, t.CREATED_BY_USER_ID, t.LAST_UPDATED_DATE });

            // Properties
            this.Property(t => t.FORM_INDIVIDUAL_SET_NOTE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOTE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOTE_TEXT)
                .IsRequired();

            this.Property(t => t.FORM_INDIVIDUAL_SET_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_USER_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3831354236444330");
            this.Property(t => t.FORM_INDIVIDUAL_SET_NOTE_ID).HasColumnName("FORM_INDIVIDUAL_SET_NOTE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.NOTE_ID).HasColumnName("NOTE_ID");
            this.Property(t => t.NOTE_TEXT).HasColumnName("NOTE_TEXT");
            this.Property(t => t.FORM_INDIVIDUAL_SET_ID).HasColumnName("FORM_INDIVIDUAL_SET_ID");
            this.Property(t => t.ARCHIVED).HasColumnName("ARCHIVED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
        }
    }
}
