using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_ATTRIBUTEMap : EntityTypeConfiguration<ACTIVITY_ATTRIBUTE>
    {
        public ACTIVITY_ATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_ATTRIBUTE_ID);

            // Properties
            this.Property(t => t.CHURCH_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ACTIVITY_ATTRIBUTE_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_ATTRIBUTE");
            this.Property(t => t.ACTIVITY_ATTRIBUTE_ID).HasColumnName("ACTIVITY_ATTRIBUTE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ATTRIBUTE_NAME).HasColumnName("ACTIVITY_ATTRIBUTE_NAME");
            this.Property(t => t.IS_PERIPHERAL).HasColumnName("IS_PERIPHERAL");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.OLD_ACT_ATTR_ID).HasColumnName("OLD_ACT_ATTR_ID");
        }
    }
}
