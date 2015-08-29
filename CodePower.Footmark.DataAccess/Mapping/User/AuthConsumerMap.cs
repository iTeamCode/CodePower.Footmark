using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess.Mapping.User
{
    public class AuthConsumerMap : EntityTypeConfiguration<AuthConsumerDM>
    {
        public AuthConsumerMap(string schema = "dbo")
        {
            // Primary Key
            this.HasKey(t => t.SysNo);

            // Properties
            this.Property(t => t.ConsumerName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ConsumerKey)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ConsumerSecret)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreateUserName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UpdateUserName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable(string.Format("{0}.AuthConsumer", schema));
            this.Property(t => t.SysNo).HasColumnName("SysNo");
            this.Property(t => t.ConsumerAppID).HasColumnName("ConsumerAppID");
            this.Property(t => t.ConsumerName).HasColumnName("ConsumerName");
            this.Property(t => t.ConsumerKey).HasColumnName("ConsumerKey");
            this.Property(t => t.ConsumerSecret).HasColumnName("ConsumerSecret");
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
