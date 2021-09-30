using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNET_MVC_Framework_EntityCRUD_2.Startup))]
namespace ASPNET_MVC_Framework_EntityCRUD_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
