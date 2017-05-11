using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlashcardApp.Startup))]
namespace FlashcardApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
