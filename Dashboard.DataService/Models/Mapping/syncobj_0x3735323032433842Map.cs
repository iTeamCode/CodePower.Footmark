using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3735323032433842Map : EntityTypeConfiguration<syncobj_0x3735323032433842>
    {
        public syncobj_0x3735323032433842Map()
        {
            // Primary Key
            this.HasKey(t => new { t.VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM, t.CHURCH_ID, t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID, t.VOLUNTEER_OPPORTUNITY_ITEM_ID, t.IS_ACTIVE, t.IS_INTERESTED, t.HAS_MINSITRY_PROCESSED, t.VOLUNTEER_OPPORTUNITY_STATUS_ID });

            // Properties
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VOLUNTEER_OPPORTUNITY_ITEM_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VOLUNTEER_OPPORTUNITY_STATUS_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3735323032433842");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM).HasColumnName("VOLUNTEER_OPPORTUNITY_INSTANCE_ITEM");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_INSTANCE_ID");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_ITEM_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_ITEM_ID");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.IS_INTERESTED).HasColumnName("IS_INTERESTED");
            this.Property(t => t.HAS_MINSITRY_PROCESSED).HasColumnName("HAS_MINSITRY_PROCESSED");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_STATUS_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_STATUS_ID");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_REJECTION_NOTE_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_REJECTION_NOTE_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
