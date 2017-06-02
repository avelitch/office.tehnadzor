using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(office.tehnadzor.Startup))]
namespace office.tehnadzor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
