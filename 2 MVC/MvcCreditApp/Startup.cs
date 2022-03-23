using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCreditApp.Startup))]
namespace MvcCreditApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
