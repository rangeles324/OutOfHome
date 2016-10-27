using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OOH.Startup))]
namespace OOH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
