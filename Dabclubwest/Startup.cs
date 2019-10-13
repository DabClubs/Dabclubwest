using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dabclubwest.Startup))]
namespace Dabclubwest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
