using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3144394535353943Map : EntityTypeConfiguration<syncobj_0x3144394535353943>
    {
        public syncobj_0x3144394535353943Map()
        {
            // Primary Key
            this.HasKey(t => new { t.THEME_ID, t.THEME_NAME, t.CHURCH_ID, t.CREATED_DATE, t.CREATED_BY_LOGIN, t.CREATED_BY_USER_ID, t.IS_DELETED });

            // Properties
            this.Property(t => t.THEME_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.THEME_NAME)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CREATED_BY_USER_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.DELETED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.IS_DELETED)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BackgroundImage_Path)
                .HasMaxLength(500);

            this.Property(t => t.ConfirmImage_Path)
                .HasMaxLength(500);

            this.Property(t => t.WelcomeImage_Path)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3144394535353943");
            this.Property(t => t.THEME_ID).HasColumnName("THEME_ID");
            this.Property(t => t.THEME_NAME).HasColumnName("THEME_NAME");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.COLOR_SET_ID).HasColumnName("COLOR_SET_ID");
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
            this.Property(t => t.BackgroundImage_Path).HasColumnName("BackgroundImage_Path");
            this.Property(t => t.ConfirmImage_Path).HasColumnName("ConfirmImage_Path");
            this.Property(t => t.WelcomeImage_Path).HasColumnName("WelcomeImage_Path");
        }
    }
}
