using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace BookStoreAbpSolution.Blazor.Client;

public class BookStoreAbpSolutionStyleBundleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add(new BundleFile("main.css", true));
    }
}
