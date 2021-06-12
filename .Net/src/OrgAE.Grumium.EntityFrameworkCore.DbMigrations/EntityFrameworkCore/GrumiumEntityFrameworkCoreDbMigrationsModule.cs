using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace OrgAE.Grumium.EntityFrameworkCore
{
    [DependsOn(
        typeof(GrumiumEntityFrameworkCoreModule)
        )]
    public class GrumiumEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<GrumiumMigrationsDbContext>();
        }
    }
}
