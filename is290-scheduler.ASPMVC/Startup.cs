using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(is290_scheduler.ASPMVC.Startup))]
namespace is290_scheduler.ASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
