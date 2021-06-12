using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace OrgAE.Grumium
{
    [Dependency(ReplaceServices = true)]
    public class GrumiumBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Grumium";
    }
}
