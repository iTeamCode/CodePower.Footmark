using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodePower.Footmark.WebPortal.Startup))]
namespace CodePower.Footmark.WebPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
