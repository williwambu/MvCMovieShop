using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvCMovieShop.Startup))]
namespace MvCMovieShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
