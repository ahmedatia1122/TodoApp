using TodoApplication.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TodoApplication.Permissions;

public class TodoApplicationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TodoApplicationPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TodoApplicationPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TodoApplicationResource>(name);
    }
}
