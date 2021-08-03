using OrgAE.Grumium.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace OrgAE.Grumium.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(GrumiumEntityFrameworkCoreModule),
        typeof(GrumiumApplicationContractsModule)
        )]
    public class GrumiumDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
