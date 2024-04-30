using Volo.Abp.Settings;

namespace TodoApplication.Settings;

public class TodoApplicationSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TodoApplicationSettings.MySetting1));
    }
}
