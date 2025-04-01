using BookStoreAbpSolution.Localization;
using Volo.Abp.Application.Services;

namespace BookStoreAbpSolution;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAbpSolutionAppService : ApplicationService
{
    protected BookStoreAbpSolutionAppService()
    {
        LocalizationResource = typeof(BookStoreAbpSolutionResource);
    }
}
