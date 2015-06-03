using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4345314337353141Map : EntityTypeConfiguration<syncobj_0x4345314337353141>
    {
        public syncobj_0x4345314337353141Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REFERENCE_QUESTION_ID, t.CHURCH_ID, t.DESCRIPTION, t.ANSWER_TYPE_ID, t.IS_ACTIVE });

            // Properties
            this.Property(t => t.REFERENCE_QUESTION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESCRIPTION)
                .IsRequired();

            this.Property(t => t.ANSWER_TYPE_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x4345314337353141");
            this.Property(t => t.REFERENCE_QUESTION_ID).HasColumnName("REFERENCE_QUESTION_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.ANSWER_TYPE_ID).HasColumnName("ANSWER_TYPE_ID");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
