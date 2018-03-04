using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FluentApiProject.Startup))]
namespace FluentApiProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
