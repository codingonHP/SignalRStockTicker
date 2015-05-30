using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineStockTickr.Startup))]
namespace OnlineStockTickr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
			app.MapSignalR();
        }
    }
}
