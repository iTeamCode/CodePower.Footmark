using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x4146353038323545Map : EntityTypeConfiguration<syncobj_0x4146353038323545>
    {
        public syncobj_0x4146353038323545Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_ATTRIBUTE_ID, t.CHURCH_ID, t.ACTIVITY_ATTRIBUTE_NAME, t.IS_PERIPHERAL });

            // Properties
            this.Property(t => t.ACTIVITY_ATTRIBUTE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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
            this.ToTable("syncobj_0x4146353038323545");
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
