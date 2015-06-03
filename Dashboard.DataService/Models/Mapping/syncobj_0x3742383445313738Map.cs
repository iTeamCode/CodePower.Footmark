using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3742383445313738Map : EntityTypeConfiguration<syncobj_0x3742383445313738>
    {
        public syncobj_0x3742383445313738Map()
        {
            // Primary Key
            this.HasKey(t => new { t.JOB_ID, t.CHURCH_ID, t.JOB_TITLE, t.DYD_ENABLED, t.ENFORCE_RESTRICTIONS, t.IS_ACTIVE });

            // Properties
            this.Property(t => t.JOB_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JOB_TITLE)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.JOB_DESCRIPTION)
                .HasMaxLength(1000);

            this.Property(t => t.POSITION_CONTACT)
                .HasMaxLength(30);

            this.Property(t => t.GENDER)
                .HasMaxLength(6);

            this.Property(t => t.MARITAL_STATUS)
                .HasMaxLength(10);

            this.Property(t => t.MINISTRY_PURPOSE)
                .HasMaxLength(100);

            this.Property(t => t.REQUIREMENTS)
                .HasMaxLength(100);

            this.Property(t => t.TRAINING_REQUIREMENTS)
                .HasMaxLength(100);

            this.Property(t => t.TIME_COMMITMENT_REQUIRED)
                .HasMaxLength(100);

            this.Property(t => t.COMMENTS)
                .HasMaxLength(1000);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3742383445313738");
            this.Property(t => t.JOB_ID).HasColumnName("JOB_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.JOB_TITLE).HasColumnName("JOB_TITLE");
            this.Property(t => t.JOB_DESCRIPTION).HasColumnName("JOB_DESCRIPTION");
            this.Property(t => t.MINISTRY_ID).HasColumnName("MINISTRY_ID");
            this.Property(t => t.DYD_ENABLED).HasColumnName("DYD_ENABLED");
            this.Property(t => t.POSITION_CONTACT).HasColumnName("POSITION_CONTACT");
            this.Property(t => t.POSITION_LEVEL).HasColumnName("POSITION_LEVEL");
            this.Property(t => t.PAYOFF_1).HasColumnName("PAYOFF_1");
            this.Property(t => t.PAYOFF_2).HasColumnName("PAYOFF_2");
            this.Property(t => t.SUBJECT_MATTER_1).HasColumnName("SUBJECT_MATTER_1");
            this.Property(t => t.SUBJECT_MATTER_2).HasColumnName("SUBJECT_MATTER_2");
            this.Property(t => t.SUBJECT_MATTER_3).HasColumnName("SUBJECT_MATTER_3");
            this.Property(t => t.CIRCUMSTANCE_1).HasColumnName("CIRCUMSTANCE_1");
            this.Property(t => t.CIRCUMSTANCE_2).HasColumnName("CIRCUMSTANCE_2");
            this.Property(t => t.CIRCUMSTANCE_3).HasColumnName("CIRCUMSTANCE_3");
            this.Property(t => t.GENDER).HasColumnName("GENDER");
            this.Property(t => t.MARITAL_STATUS).HasColumnName("MARITAL_STATUS");
            this.Property(t => t.REPORTS_TO_INDIVIDUAL).HasColumnName("REPORTS_TO_INDIVIDUAL");
            this.Property(t => t.MINISTRY_PURPOSE).HasColumnName("MINISTRY_PURPOSE");
            this.Property(t => t.REQUIREMENTS).HasColumnName("REQUIREMENTS");
            this.Property(t => t.TRAINING_REQUIREMENTS).HasColumnName("TRAINING_REQUIREMENTS");
            this.Property(t => t.BACKGROUND_CHECK).HasColumnName("BACKGROUND_CHECK");
            this.Property(t => t.TIME_COMMITMENT_REQUIRED).HasColumnName("TIME_COMMITMENT_REQUIRED");
            this.Property(t => t.CHRISTIAN_MATURITY_REQUIRED).HasColumnName("CHRISTIAN_MATURITY_REQUIRED");
            this.Property(t => t.COMMENTS).HasColumnName("COMMENTS");
            this.Property(t => t.ABILITY_1).HasColumnName("ABILITY_1");
            this.Property(t => t.ABILITY_2).HasColumnName("ABILITY_2");
            this.Property(t => t.ABILITY_3).HasColumnName("ABILITY_3");
            this.Property(t => t.ABILITY_4).HasColumnName("ABILITY_4");
            this.Property(t => t.ABILITY_5).HasColumnName("ABILITY_5");
            this.Property(t => t.ABILITY_6).HasColumnName("ABILITY_6");
            this.Property(t => t.MINIMUM_AGE).HasColumnName("MINIMUM_AGE");
            this.Property(t => t.OLD_JOB_ID).HasColumnName("OLD_JOB_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.CONTACT_INDIVIDUAL_ID).HasColumnName("CONTACT_INDIVIDUAL_ID");
            this.Property(t => t.REPORTS_TO_INDIVIDUAL_ID).HasColumnName("REPORTS_TO_INDIVIDUAL_ID");
            this.Property(t => t.ENFORCE_RESTRICTIONS).HasColumnName("ENFORCE_RESTRICTIONS");
            this.Property(t => t.MAXIMUM_AGE).HasColumnName("MAXIMUM_AGE");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.DEFAULT_TIME_SERVED).HasColumnName("DEFAULT_TIME_SERVED");
        }
    }
}
