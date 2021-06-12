using OrgAE.Grumium.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OrgAE.Grumium.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class GrumiumController : AbpController
    {
        protected GrumiumController()
        {
            LocalizationResource = typeof(GrumiumResource);
        }
    }
}