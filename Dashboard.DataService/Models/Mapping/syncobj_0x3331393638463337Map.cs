using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3331393638463337Map : EntityTypeConfiguration<syncobj_0x3331393638463337>
    {
        public syncobj_0x3331393638463337Map()
        {
            // Primary Key
            this.HasKey(t => new { t.VOLUNTEER_OPPORTUNITY_INSTANCE_NOTE_ID, t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID, t.CHURCH_ID, t.NOTE });

            // Properties
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_NOTE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOTE)
                .IsRequired()
                .HasMaxLength(4000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3331393638463337");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_NOTE_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_INSTANCE_NOTE_ID");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_INSTANCE_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.NOTE).HasColumnName("NOTE");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
