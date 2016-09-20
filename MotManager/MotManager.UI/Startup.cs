using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MotManager.UI.Startup))]
namespace MotManager.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
