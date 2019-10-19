using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Crud.Startup))]
namespace MVC_Crud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
