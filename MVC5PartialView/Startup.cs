using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5PartialView.Startup))]
namespace MVC5PartialView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
