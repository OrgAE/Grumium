using OrgAE.Grumium.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OrgAE.Grumium
{
    [DependsOn(
        typeof(GrumiumEntityFrameworkCoreTestModule)
        )]
    public class GrumiumDomainTestModule : AbpModule
    {

    }
}