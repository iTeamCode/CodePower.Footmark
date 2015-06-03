using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3431373441314537Map : EntityTypeConfiguration<syncobj_0x3431373441314537>
    {
        public syncobj_0x3431373441314537Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REFERENCE_ID, t.REFERENCE_QUESTION_ID, t.DESCRIPTION, t.REFERENCE_INSTANCE_ID });

            // Properties
            this.Property(t => t.REFERENCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.REFERENCE_QUESTION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRIPTION)
                .IsRequired();

            this.Property(t => t.REFERENCE_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3431373441314537");
            this.Property(t => t.REFERENCE_ID).HasColumnName("REFERENCE_ID");
            this.Property(t => t.REFERENCE_QUESTION_ID).HasColumnName("REFERENCE_QUESTION_ID");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.REFERENCE_INSTANCE_ID).HasColumnName("REFERENCE_INSTANCE_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
