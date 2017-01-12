using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicHouse.Startup))]
namespace MusicHouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
