using BookStoreAbpSolution.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BookStoreAbpSolution.Blazor.Client;

public abstract class BookStoreAbpSolutionComponentBase : AbpComponentBase
{
    protected BookStoreAbpSolutionComponentBase()
    {
        LocalizationResource = typeof(BookStoreAbpSolutionResource);
    }
}
