using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIFFv2.Startup))]
namespace SIFFv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
