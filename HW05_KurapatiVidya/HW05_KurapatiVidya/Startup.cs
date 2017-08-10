using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW05_KurapatiVidya.Startup))]
namespace HW05_KurapatiVidya
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
