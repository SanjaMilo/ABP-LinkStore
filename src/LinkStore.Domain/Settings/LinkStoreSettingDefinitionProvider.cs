using Volo.Abp.Settings;

namespace LinkStore.Settings;

public class LinkStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LinkStoreSettings.MySetting1));
    }
}
