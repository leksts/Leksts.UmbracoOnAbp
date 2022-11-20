using Leksts.UmbracoOnAbp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Leksts.UmbracoOnAbp.Permissions;

public class UmbracoOnAbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(UmbracoOnAbpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(UmbracoOnAbpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<UmbracoOnAbpResource>(name);
    }
}
