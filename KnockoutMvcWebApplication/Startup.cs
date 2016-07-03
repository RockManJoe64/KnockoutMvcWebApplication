using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnockoutMvcWebApplication.Startup))]
namespace KnockoutMvcWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
