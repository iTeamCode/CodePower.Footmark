using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_TYPE_GROUPMap : EntityTypeConfiguration<INDIVIDUAL_TYPE_GROUP>
    {
        public INDIVIDUAL_TYPE_GROUPMap()
        {
            // Primary Key
            this.HasKey(t => t.INDIVIDUAL_TYPE_GROUP_ID);

            // Properties
            this.Property(t => t.INDIVIDUAL_TYPE_GROUP_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INDIVIDUAL_TYPE_GROUP_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_TYPE_GROUP");
            this.Property(t => t.INDIVIDUAL_TYPE_GROUP_ID).HasColumnName("INDIVIDUAL_TYPE_GROUP_ID");
            this.Property(t => t.INDIVIDUAL_TYPE_GROUP_NAME).HasColumnName("INDIVIDUAL_TYPE_GROUP_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_USER_ID).HasColumnName("LAST_UPDATED_USER_ID");
        }
    }
}
