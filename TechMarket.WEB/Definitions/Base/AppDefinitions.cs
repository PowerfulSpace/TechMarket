using TechMarket.WEB.Definitions.Base.Interfaces;

namespace TechMarket.WEB.Definitions.Base
{
    public abstract class AppDefinitions : IAppDefinitions
    {
        public virtual void ConfigureApplication(WebApplication app, IWebHostEnvironment environment) { }

        public virtual void ConfigureServices(IServiceCollection services, IConfiguration configuration) { }
    }
}
