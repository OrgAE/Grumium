using OrgAE.Grumium.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OrgAE.Grumium.Permissions
{
    public class GrumiumPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(GrumiumPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(GrumiumPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<GrumiumResource>(name);
        }
    }
}
