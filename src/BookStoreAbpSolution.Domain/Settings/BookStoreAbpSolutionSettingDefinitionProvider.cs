using Volo.Abp.Settings;

namespace BookStoreAbpSolution.Settings;

public class BookStoreAbpSolutionSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStoreAbpSolutionSettings.MySetting1));
    }
}
