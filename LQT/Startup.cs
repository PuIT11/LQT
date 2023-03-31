using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LQT.Startup))]
namespace LQT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
