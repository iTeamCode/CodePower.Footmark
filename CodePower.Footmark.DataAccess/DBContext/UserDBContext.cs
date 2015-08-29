using CodePower.Footmark.DataAccess.Mapping.User;
using CodePower.Footmark.Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.DataAccess.DBContext
{
    public partial class UserDBContext : DbContext
    {
        static UserDBContext()
        {
            Database.SetInitializer<UserDBContext>(null);
        }

        public UserDBContext() : base("name=UserDBContext") { }

        public DbSet<AuthConsumerDM> AuthConsumers { get; set; }
        public DbSet<AuthTokenDM> AuthTokens { get; set; }
        public DbSet<UserInformationDM> UserInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthConsumerMap());
            modelBuilder.Configurations.Add(new AuthTokenMap());
            modelBuilder.Configurations.Add(new UserInformationMap());
        }
    }
}
