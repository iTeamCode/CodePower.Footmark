using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_GROUPMap : EntityTypeConfiguration<ACTIVITY_GROUP>
    {
        public ACTIVITY_GROUPMap()
        {
            // Primary Key
            this.HasKey(t => t.ACTIVITY_GROUP_ID);

            // Properties
            this.Property(t => t.ACTIVITY_GROUP_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_GROUP");
            this.Property(t => t.ACTIVITY_GROUP_ID).HasColumnName("ACTIVITY_GROUP_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_GROUP_NAME).HasColumnName("ACTIVITY_GROUP_NAME");
            this.Property(t => t.ACTIVITY_SUPER_GROUP_ID).HasColumnName("ACTIVITY_SUPER_GROUP_ID");
            this.Property(t => t.ACTIVITY_GROUP_SORT).HasColumnName("ACTIVITY_GROUP_SORT");
            this.Property(t => t.CHECKIN_BALANCE_TYPE).HasColumnName("CHECKIN_BALANCE_TYPE");
            this.Property(t => t.OLD_ACT_GRP_ID).HasColumnName("OLD_ACT_GRP_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.OLD_ACT_SUPER_GRP_ID).HasColumnName("OLD_ACT_SUPER_GRP_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.ACTIVITY_GROUP)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasOptional(t => t.ACTIVITY_GROUP2)
                .WithMany(t => t.ACTIVITY_GROUP1)
                .HasForeignKey(d => d.ACTIVITY_SUPER_GROUP_ID);

        }
    }
}
