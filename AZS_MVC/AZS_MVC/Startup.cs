using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AZS_MVC.Startup))]
namespace AZS_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
