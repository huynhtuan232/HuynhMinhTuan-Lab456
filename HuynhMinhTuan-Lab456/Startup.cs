using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuynhMinhTuan_Lab456.Startup))]
namespace HuynhMinhTuan_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
