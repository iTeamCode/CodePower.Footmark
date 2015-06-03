using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class GLOBAL_MINISTRYMap : EntityTypeConfiguration<GLOBAL_MINISTRY>
    {
        public GLOBAL_MINISTRYMap()
        {
            // Primary Key
            this.HasKey(t => t.GLOBAL_MINISTRY_ID);

            // Properties
            this.Property(t => t.GLOBAL_MINISTRY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GLOBAL_MINISTRY_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GLOBAL_MINISTRY");
            this.Property(t => t.GLOBAL_MINISTRY_ID).HasColumnName("GLOBAL_MINISTRY_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.GLOBAL_MINISTRY_NAME).HasColumnName("GLOBAL_MINISTRY_NAME");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
        }
    }
}
