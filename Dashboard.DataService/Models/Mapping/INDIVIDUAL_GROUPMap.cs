using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_GROUPMap : EntityTypeConfiguration<INDIVIDUAL_GROUP>
    {
        public INDIVIDUAL_GROUPMap()
        {
            // Primary Key
            this.HasKey(t => t.INDIVIDUAL_GROUP_ID);

            // Properties
            this.Property(t => t.INDIVIDUAL_GROUP_NAME)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DESCRIPTION)
                .HasMaxLength(50);

            this.Property(t => t.TAG_CODE)
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_GROUP");
            this.Property(t => t.INDIVIDUAL_GROUP_ID).HasColumnName("INDIVIDUAL_GROUP_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INDIVIDUAL_GROUP_NAME).HasColumnName("INDIVIDUAL_GROUP_NAME");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.DESCRIPTION).HasColumnName("DESCRIPTION");
            this.Property(t => t.TAG_CODE).HasColumnName("TAG_CODE");
            this.Property(t => t.old_ind_grp_id).HasColumnName("old_ind_grp_id");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.INDIVIDUAL_GROUP)
                .HasForeignKey(d => d.ACTIVITY_ID);

        }
    }
}
