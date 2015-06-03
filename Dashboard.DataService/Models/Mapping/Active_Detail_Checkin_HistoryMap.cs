using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Selenium.DataService.Models.Mapping
{
    public class Active_Detail_Checkin_HistoryMap : EntityTypeConfiguration<Active_Detail_Checkin_History>
    {
        public Active_Detail_Checkin_HistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Active_Detail_Checkin_History_ID);

            // Properties
            this.Property(t => t.CREATED_BY_LOGIN)
                .HasMaxLength(20);

            this.Property(t => t.LAST_UPDATED_BY_LOGIN)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Active_Detail_Checkin_History");
            this.Property(t => t.Active_Detail_Checkin_History_ID).HasColumnName("Active_Detail_Checkin_History_ID");
            this.Property(t => t.ACTIVITY_DETAIL_ID).HasColumnName("ACTIVITY_DETAIL_ID");
            this.Property(t => t.ACTIVE_CHECKIN_ID).HasColumnName("ACTIVE_CHECKIN_ID");
            this.Property(t => t.CHURCH_ID).HasColumnName("CHURCH_ID");
            this.Property(t => t.IS_OPEN).HasColumnName("IS_OPEN");
            this.Property(t => t.CAPACITY).HasColumnName("CAPACITY");
            this.Property(t => t.VOLUNTEER_COUNT).HasColumnName("VOLUNTEER_COUNT");
            this.Property(t => t.HOLDOVER_COUNT).HasColumnName("HOLDOVER_COUNT");
            this.Property(t => t.CREATED_DATE).HasColumnName("CREATED_DATE");
            this.Property(t => t.CREATED_BY_LOGIN).HasColumnName("CREATED_BY_LOGIN");
            this.Property(t => t.CREATED_BY_USER_ID).HasColumnName("CREATED_BY_USER_ID");
            this.Property(t => t.LAST_UPDATED_DATE).HasColumnName("LAST_UPDATED_DATE");
            this.Property(t => t.LAST_UPDATED_BY_LOGIN).HasColumnName("LAST_UPDATED_BY_LOGIN");
            this.Property(t => t.LAST_UPDATED_BY_USER_ID).HasColumnName("LAST_UPDATED_BY_USER_ID");
            this.Property(t => t.Audit_Created_Date).HasColumnName("Audit_Created_Date");
        }
    }
}