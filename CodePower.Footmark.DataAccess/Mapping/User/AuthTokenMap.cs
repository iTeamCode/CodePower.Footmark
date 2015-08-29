using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess.Mapping.User
{
    public class AuthTokenMap : EntityTypeConfiguration<AuthTokenDM>
    {
        public AuthTokenMap(string schema = "dbo")
        {
            // Primary Key
            this.HasKey(t => t.SysNo);

            // Properties
            this.Property(t => t.AccessToken)
                .HasMaxLength(200);

            this.Property(t => t.RefreshToken)
                .HasMaxLength(200);

            this.Property(t => t.ConfusionCode)
                .HasMaxLength(30);

            this.Property(t => t.CreateUserName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UpdateUserName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable(string.Format("{0}.AuthToken", schema));
            this.Property(t => t.SysNo).HasColumnName("SysNo");
            this.Property(t => t.AuthConsumerSysNo).HasColumnName("AuthConsumerSysNo");
            this.Property(t => t.UserSysNo).HasColumnName("UserSysNo");
            this.Property(t => t.TypeId).HasColumnName("TypeID");
            this.Property(t => t.AccessToken).HasColumnName("AccessToken");
            this.Property(t => t.RefreshToken).HasColumnName("RefreshToken");
            this.Property(t => t.ConfusionCode).HasColumnName("ConfusionCode");
            this.Property(t => t.ExpirationTime).HasColumnName("ExpirationTime");
            this.Property(t => t.ExpirationInterval).HasColumnName("ExpirationInterval");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateUserSysNo).HasColumnName("CreateUserSysNo");
            this.Property(t => t.CreateUserName).HasColumnName("CreateUserName");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.UpdateUserSysNo).HasColumnName("UpdateUserSysNo");
            this.Property(t => t.UpdateUserName).HasColumnName("UpdateUserName");

            // Relationships
            this.HasRequired(t => t.Consumer)
                .WithMany(t => t.Tokens)
                .HasForeignKey(d => d.AuthConsumerSysNo);
        }
    }
}
