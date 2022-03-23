using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalExercise.Startup))]
namespace FinalExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
