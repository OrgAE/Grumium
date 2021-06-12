using Volo.Abp.Settings;

namespace OrgAE.Grumium.Settings
{
    public class GrumiumSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(GrumiumSettings.MySetting1));
        }
    }
}
