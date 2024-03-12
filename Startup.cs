using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Integrated_Product_Management.Startup))]
namespace Integrated_Product_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
