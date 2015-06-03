using Microsoft.Owin;
using Owin;

//[assembly: OwinStartupAttribute(typeof(Dashboard.WebPortal.Startup))]
[assembly: OwinStartup(typeof(CodePower.Footmark.WebPortal.Startup))]
namespace CodePower.Footmark.WebPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
