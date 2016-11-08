using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelMVCSite.Startup))]
namespace TravelMVCSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
