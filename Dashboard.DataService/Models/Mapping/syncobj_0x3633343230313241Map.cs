using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3633343230313241Map : EntityTypeConfiguration<syncobj_0x3633343230313241>
    {
        public syncobj_0x3633343230313241Map()
        {
            // Primary Key
            this.HasKey(t => new { t.REFERENCE_ID, t.FIRST_NAME, t.LAST_NAME, t.RELATIONSHIP, t.IS_CLOSED, t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID });

            // Properties
            this.Property(t => t.REFERENCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FIRST_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.LAST_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ADDRESS)
                .HasMaxLength(40);

            this.Property(t => t.CITY)
                .HasMaxLength(30);

            this.Property(t => t.ST_PROVINCE)
                .HasMaxLength(125);

            this.Property(t => t.POSTAL_CODE)
                .HasMaxLength(10);

            this.Property(t => t.HOME_PHONE)
                .HasMaxLength(15);

            this.Property(t => t.WORK_PHONE)
                .HasMaxLength(15);

            this.Property(t => t.EMAIL)
                .HasMaxLength(50);

            this.Property(t => t.RELATIONSHIP)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.ADDRESS_2)
                .HasMaxLength(50);

            this.Property(t => t.ADDRESS_3)
                .HasMaxLength(50);

            this.Property(t => t.COUNTRY)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3633343230313241");
            this.Property(t => t.REFERENCE_ID).HasColumnName("REFERENCE_ID");
            this.Property(t => t.FIRST_NAME).HasColumnName("FIRST_NAME");
            this.Property(t => t.LAST_NAME).HasColumnName("LAST_NAME");
            this.Property(t => t.ADDRESS).HasColumnName("ADDRESS");
            this.Property(t => t.CITY).HasColumnName("CITY");
            this.Property(t => t.ST_PROVINCE).HasColumnName("ST_PROVINCE");
            this.Property(t => t.POSTAL_CODE).HasColumnName("POSTAL_CODE");
            this.Property(t => t.HOME_PHONE).HasColumnName("HOME_PHONE");
            this.Property(t => t.WORK_PHONE).HasColumnName("WORK_PHONE");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.RELATIONSHIP).HasColumnName("RELATIONSHIP");
            this.Property(t => t.IS_CLOSED).HasColumnName("IS_CLOSED");
            this.Property(t => t.VOLUNTEER_OPPORTUNITY_INSTANCE_ID).HasColumnName("VOLUNTEER_OPPORTUNITY_INSTANCE_ID");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.ADDRESS_2).HasColumnName("ADDRESS_2");
            this.Property(t => t.ADDRESS_3).HasColumnName("ADDRESS_3");
            this.Property(t => t.COUNTRY).HasColumnName("COUNTRY");
        }
    }
}
