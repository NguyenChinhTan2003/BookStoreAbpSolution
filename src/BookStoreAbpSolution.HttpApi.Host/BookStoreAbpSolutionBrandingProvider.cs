using Microsoft.Extensions.Localization;
using BookStoreAbpSolution.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookStoreAbpSolution;

[Dependency(ReplaceServices = true)]
public class BookStoreAbpSolutionBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookStoreAbpSolutionResource> _localizer;

    public BookStoreAbpSolutionBrandingProvider(IStringLocalizer<BookStoreAbpSolutionResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
