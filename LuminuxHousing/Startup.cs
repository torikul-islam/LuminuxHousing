using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuminuxHousing.Startup))]
namespace LuminuxHousing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
