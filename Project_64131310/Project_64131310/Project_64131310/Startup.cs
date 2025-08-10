using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_64131310.Startup))]
namespace Project_64131310
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
