using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class TAG_DATA_FIELDMap : EntityTypeConfiguration<TAG_DATA_FIELD>
    {
        public TAG_DATA_FIELDMap()
        {
            // Primary Key
            this.HasKey(t => t.TAG_DATA_FIELD_ID);

            // Properties
            this.Property(t => t.DATABASE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TABLE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TABLE_COLUMN)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FORMAT)
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("TAG_DATA_FIELD");
            this.Property(t => t.TAG_DATA_FIELD_ID).HasColumnName("TAG_DATA_FIELD_ID");
            this.Property(t => t.DATABASE_NAME).HasColumnName("DATABASE_NAME");
            this.Property(t => t.TABLE_NAME).HasColumnName("TABLE_NAME");
            this.Property(t => t.TABLE_COLUMN).HasColumnName("TABLE_COLUMN");
            this.Property(t => t.FORMAT).HasColumnName("FORMAT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
