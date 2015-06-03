using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class INDIVIDUAL_PREFSMap : EntityTypeConfiguration<INDIVIDUAL_PREFS>
    {
        public INDIVIDUAL_PREFSMap()
        {
            // Primary Key
            this.HasKey(t => t.INDIVIDUAL_PREF_ID);

            // Properties
            this.Property(t => t.DEFAULT_TAG_COMMENT)
                .HasMaxLength(50);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("INDIVIDUAL_PREFS");
            this.Property(t => t.INDIVIDUAL_PREF_ID).HasColumnName("INDIVIDUAL_PREF_ID");
            this.Property(t => t.INDIVIDUAL_ID).HasColumnName("INDIVIDUAL_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.ACTIVITY_INSTANCE_ID).HasColumnName("ACTIVITY_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.INDIVIDUAL_GROUP_ID).HasColumnName("INDIVIDUAL_GROUP_ID");
            this.Property(t => t.DEFAULT_TAG_COMMENT).HasColumnName("DEFAULT_TAG_COMMENT");
            this.Property(t => t.END_ACTIVITY_INSTANCE_ID).HasColumnName("END_ACTIVITY_INSTANCE_ID");
            this.Property(t => t.INDIVIDUAL_REGISTRATION_ID).HasColumnName("INDIVIDUAL_REGISTRATION_ID");
            this.Property(t => t.LAST_MOVE_DATE).HasColumnName("LAST_MOVE_DATE");
            this.Property(t => t.LAST_ACTIVITY_DETAIL).HasColumnName("LAST_ACTIVITY_DETAIL");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.MassActionID).HasColumnName("MassActionID");

            // Relationships
            this.HasRequired(t => t.ACTIVITY)
                .WithMany(t => t.INDIVIDUAL_PREFS)
                .HasForeignKey(d => d.ACTIVITY_ID);
            this.HasOptional(t => t.ACTIVITY_DETAIL)
                .WithMany(t => t.INDIVIDUAL_PREFS)
                .HasForeignKey(d => d.ACTIVITY_DETAIL_ID);
            this.HasOptional(t => t.INDIVIDUAL_GROUP)
                .WithMany(t => t.INDIVIDUAL_PREFS)
                .HasForeignKey(d => d.INDIVIDUAL_GROUP_ID);
            this.HasOptional(t => t.INDIVIDUAL_REGISTRATION_2)
                .WithMany(t => t.INDIVIDUAL_PREFS)
                .HasForeignKey(d => d.INDIVIDUAL_REGISTRATION_ID);

        }
    }
}
