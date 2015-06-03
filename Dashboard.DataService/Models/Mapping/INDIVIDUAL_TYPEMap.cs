using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_TYPEMap : EntityTypeConfiguration<INDIVIDUAL_TYPE>
    {
        public INDIVIDUAL_TYPEMap()
        {
            // Primary Key
            this.HasKey(t => t.INDIVIDUAL_TYPE_ID);

            // Properties
            this.Property(t => t.INDIVIDUAL_TYPE_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_TYPE");
            this.Property(t => t.INDIVIDUAL_TYPE_ID).HasColumnName("INDIVIDUAL_TYPE_ID");
            this.Property(t => t.INDIVIDUAL_TYPE_NAME).HasColumnName("INDIVIDUAL_TYPE_NAME");
            this.Property(t => t.HAS_TIMESHEET).HasColumnName("HAS_TIMESHEET");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.INDIVIDUAL_TYPE_GROUP_ID).HasColumnName("INDIVIDUAL_TYPE_GROUP_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
        }
    }
}
