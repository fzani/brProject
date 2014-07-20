using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(brProjectMVC.Startup))]
namespace brProjectMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
