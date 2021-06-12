using System;
using System.Collections.Generic;
using System.Text;
using OrgAE.Grumium.Localization;
using Volo.Abp.Application.Services;

namespace OrgAE.Grumium
{
    /* Inherit your application services from this class.
     */
    public abstract class GrumiumAppService : ApplicationService
    {
        protected GrumiumAppService()
        {
            LocalizationResource = typeof(GrumiumResource);
        }
    }
}
