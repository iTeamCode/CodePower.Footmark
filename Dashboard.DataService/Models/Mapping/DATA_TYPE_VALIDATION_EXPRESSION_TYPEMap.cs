using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class DATA_TYPE_VALIDATION_EXPRESSION_TYPEMap : EntityTypeConfiguration<DATA_TYPE_VALIDATION_EXPRESSION_TYPE>
    {
        public DATA_TYPE_VALIDATION_EXPRESSION_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DATA_TYPE_ID, t.EXPRESSION_ID });

            // Properties
            this.Property(t => t.DATA_TYPE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EXPRESSION_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("DATA_TYPE_VALIDATION_EXPRESSION_TYPE");
            this.Property(t => t.DATA_TYPE_ID).HasColumnName("DATA_TYPE_ID");
            this.Property(t => t.EXPRESSION_ID).HasColumnName("EXPRESSION_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
