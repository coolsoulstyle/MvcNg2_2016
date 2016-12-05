using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcNg2.Startup))]
namespace MvcNg2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
