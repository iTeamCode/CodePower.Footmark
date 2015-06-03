using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class COLOR_SETMap : EntityTypeConfiguration<COLOR_SET>
    {
        public COLOR_SETMap()
        {
            // Primary Key
            this.HasKey(t => t.COLOR_SET_ID);

            // Properties
            this.Property(t => t.COLOR_SET_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.COLOR_SET_NAME)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.CREATED_BY_LOGIN)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.DELETED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("COLOR_SET");
            this.Property(t => t.COLOR_SET_ID).HasColumnName("COLOR_SET_ID");
            this.Property(t => t.COLOR_SET_NAME).HasColumnName("COLOR_SET_NAME");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.DELETED_DATE).HasColumnName("DELETED_DATE");
            this.Property(t => t.DELETED_BY_LOGIN).HasColumnName("DELETED_BY_LOGIN");
            this.Property(t => t.DELETED_BY_USER_ID).HasColumnName("DELETED_BY_USER_ID");
        }
    }
}
