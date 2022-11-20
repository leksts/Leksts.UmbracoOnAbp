using Volo.Abp.Settings;

namespace Leksts.UmbracoOnAbp.Settings;

public class UmbracoOnAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(UmbracoOnAbpSettings.MySetting1));
    }
}
