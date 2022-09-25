using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaptopStore.Startup))]
namespace LaptopStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
