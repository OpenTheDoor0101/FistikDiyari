using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntProg2Odev2.Startup))]
namespace IntProg2Odev2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
