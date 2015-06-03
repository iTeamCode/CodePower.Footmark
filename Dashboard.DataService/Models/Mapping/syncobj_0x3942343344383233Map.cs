using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class syncobj_0x3942343344383233Map : EntityTypeConfiguration<syncobj_0x3942343344383233>
    {
        public syncobj_0x3942343344383233Map()
        {
            // Primary Key
            this.HasKey(t => new { t.ACTIVITY_DETAIL_ID, t.CHURCH_ID, t.ACTIVITY_DETAIL_NAME, t.ACTIVITY_ID, t.CHECKIN_ENABLED, t.Date_Range_Type_ID, t.Override_Activity });

            // Properties
            this.Property(t => t.ACTIVITY_DETAIL_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CHURCH_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACTIVITY_DETAIL_NAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ACTIVITY_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OTHER_LOCATION)
                .HasMaxLength(30);

            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.Date_Range_Type_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("syncobj_0x3942343344383233");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.ACTIVITY_DETAIL_NAME).HasColumnName("ACTIVITY_DETAIL_NAME");
            this.Property(t => t.ACTIVITY_ID).HasColumnName("ACTIVITY_ID");
            this.Property(t => t.ACTIVITY_GROUP_ID).HasColumnName("ACTIVITY_GROUP_ID");
            this.Property(t => t.DEFAULT_ROOM_ID).HasColumnName("DEFAULT_ROOM_ID");
            this.Property(t => t.OTHER_LOCATION).HasColumnName("OTHER_LOCATION");
            this.Property(t => t.CHECKIN_AUTO_OPEN).HasColumnName("CHECKIN_AUTO_OPEN");
            this.Property(t => t.CHECKIN_ENABLED).HasColumnName("CHECKIN_ENABLED");
            this.Property(t => t.DEFAULT_CAPACITY).HasColumnName("DEFAULT_CAPACITY");
            this.Property(t => t.START_AGE_DATE).HasColumnName("START_AGE_DATE");
            this.Property(t => t.END_AGE_DATE).HasColumnName("END_AGE_DATE");
            this.Property(t => t.DEFAULT_AGE).HasColumnName("DEFAULT_AGE");
            this.Property(t => t.HAS_NAMETAG).HasColumnName("HAS_NAMETAG");
            this.Property(t => t.HAS_RECEIPT).HasColumnName("HAS_RECEIPT");
            this.Property(t => t.DEFAULT_INDIVIDUAL_GROUP_ID).HasColumnName("DEFAULT_INDIVIDUAL_GROUP_ID");
            this.Property(t => t.ACTIVITY_TIME_ID).HasColumnName("ACTIVITY_TIME_ID");
            this.Property(t => t.OLD_ACT_DET_ID).HasColumnName("OLD_ACT_DET_ID");
            this.Property(t => t.IS_ACTIVE).HasColumnName("IS_ACTIVE");
            this.Property(t => t.PAGER_ENABLED).HasColumnName("PAGER_ENABLED");
            this.Property(t => t.IS_CLOSED).HasColumnName("IS_CLOSED");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.OLD_ACT_GRP_ID).HasColumnName("OLD_ACT_GRP_ID");
            this.Property(t => t.CAN_TRANSFER_CONTACTS).HasColumnName("CAN_TRANSFER_CONTACTS");
            this.Property(t => t.Start_Age_Range).HasColumnName("Start_Age_Range");
            this.Property(t => t.End_Age_Range).HasColumnName("End_Age_Range");
            this.Property(t => t.Date_Range_Type_ID).HasColumnName("Date_Range_Type_ID");
            this.Property(t => t.Override_Activity).HasColumnName("Override_Activity");
        }
    }
}
