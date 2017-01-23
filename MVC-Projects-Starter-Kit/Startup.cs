using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Projects_Starter_Kit.Startup))]
namespace MVC_Projects_Starter_Kit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
