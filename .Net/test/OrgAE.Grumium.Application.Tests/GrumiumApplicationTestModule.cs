using Volo.Abp.Modularity;

namespace OrgAE.Grumium
{
    [DependsOn(
        typeof(GrumiumApplicationModule),
        typeof(GrumiumDomainTestModule)
        )]
    public class GrumiumApplicationTestModule : AbpModule
    {

    }
}