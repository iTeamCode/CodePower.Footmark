using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_INSTANCE_HISTORYMap : EntityTypeConfiguration<INDIVIDUAL_INSTANCE_HISTORY>
    {
        public INDIVIDUAL_INSTANCE_HISTORYMap()
        {
            // Primary Key
            this.HasKey(t => t.INDIVIDUAL_INSTANCE_ID);

            // Properties
            this.Property(t => t.INDIVIDUAL_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TAG_COMMENT)
                .HasMaxLength(50);

            this.Property(t => t.TAG_CODE)
                .HasMaxLength(3);

            this.Property(t => t.PAGER_CODE)
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_INSTANCE_HISTORY");
            this.Property(t => t.INDIVIDUAL_INSTANCE_ID).HasColumnName("INDIVIDUAL_INSTANCE_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.VISITOR_ID).HasColumnName("VISITOR_ID");
            this.Property(t => t.INDIVIDUAL_TYPE_ID).HasColumnName("INDIVIDUAL_TYPE_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.TAG_COMMENT).HasColumnName("TAG_COMMENT");
            this.Property(t => t.TAG_CODE).HasColumnName("TAG_CODE");
            this.Property(t => t.INDIVIDUAL_GROUP_ID).HasColumnName("INDIVIDUAL_GROUP_ID");
            this.Property(t => t.CHECK_IN_MACHINE_ID).HasColumnName("CHECK_IN_MACHINE_ID");
            this.Property(t => t.CHECK_IN_TIME).HasColumnName("CHECK_IN_TIME");
            this.Property(t => t.CHECK_OUT_TIME).HasColumnName("CHECK_OUT_TIME");
            this.Property(t => t.PAGER_CODE).HasColumnName("PAGER_CODE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
        }
    }
}
