using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess.Mapping.User
{
    public class UserInformationMap : EntityTypeConfiguration<UserInformationDM>
    {
        public UserInformationMap(string schema = "dbo")
        {
            // Primary Key
            this.HasKey(t => t.SysNo);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreateUserName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UpdateUserName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable(string.Format("{0}.UserInformation", schema));
            this.Property(t => t.SysNo).HasColumnName("SysNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUserSysNo).HasColumnName("CreateUserSysNo");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUserSysNo).HasColumnName("UpdateUserSysNo");
            this.Property(t => t.UpdateUserName).HasColumnName("UpdateUserName");
        }
    }
}
