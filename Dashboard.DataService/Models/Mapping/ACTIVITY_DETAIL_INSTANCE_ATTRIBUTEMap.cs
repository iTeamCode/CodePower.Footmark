using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class ACTIVITY_DETAIL_INSTANCE_ATTRIBUTEMap : EntityTypeConfiguration<ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE>
    {
        public ACTIVITY_DETAIL_INSTANCE_ATTRIBUTEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_DETAIL_INSTANCE_ID, t.ACTIVITY_DETAIL_ATTRIBUTE_ID });

            // Properties
            this.Property(t => t.ACTIVITY_DETAIL_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_ATTRIBUTE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TEXT_ANSWER)
                .HasMaxLength(4000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.DELETED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE");
            this.Property(t => t.ACTIVITY_DETAIL_INSTANCE_ID).HasColumnName("ACTIVITY_DETAIL_INSTANCE_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ATTRIBUTE_ID).HasColumnName("ACTIVITY_DETAIL_ATTRIBUTE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.TEXT_ANSWER).HasColumnName("TEXT_ANSWER");
            this.Property(t => t.INTEGER_ANSWER).HasColumnName("INTEGER_ANSWER");
            this.Property(t => t.DATE_ANSWER).HasColumnName("DATE_ANSWER");
            this.Property(t => t.CURRENCY_ANSWER).HasColumnName("CURRENCY_ANSWER");
            this.Property(t => t.BOOLEAN_ANSWER).HasColumnName("BOOLEAN_ANSWER");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.DELETED_DATE).HasColumnName("DELETED_DATE");
            this.Property(t => t.DELETED_BY_LOGIN).HasColumnName("DELETED_BY_LOGIN");
            this.Property(t => t.DELETED_BY_USER_ID).HasColumnName("DELETED_BY_USER_ID");
            this.Property(t => t.IS_DELETED).HasColumnName("IS_DELETED");

            // Relationships
            this.HasRequired(t => t.ACTIVITY_DETAIL_ATTRIBUTE)
                .WithMany(t => t.ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ATTRIBUTE_ID);
            this.HasRequired(t => t.ACTIVITY_DETAIL_INSTANCE)
                .WithMany(t => t.ACTIVITY_DETAIL_INSTANCE_ATTRIBUTE)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_INSTANCE_ID);

        }
    }
}
