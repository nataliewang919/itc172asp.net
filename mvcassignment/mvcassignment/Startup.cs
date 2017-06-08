using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcassignment.Startup))]
namespace mvcassignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
