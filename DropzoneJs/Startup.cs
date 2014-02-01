using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropzoneJs.Startup))]
namespace DropzoneJs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
