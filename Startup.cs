using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kg506115MIS4200_sp20.Startup))]
namespace Kg506115MIS4200_sp20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
