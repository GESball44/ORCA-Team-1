using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ORCA_Team_1.Startup))]
namespace ORCA_Team_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
