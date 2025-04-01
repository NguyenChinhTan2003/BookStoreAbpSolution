using BookStoreAbpSolution.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookStoreAbpSolution.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreAbpSolutionController : AbpControllerBase
{
    protected BookStoreAbpSolutionController()
    {
        LocalizationResource = typeof(BookStoreAbpSolutionResource);
    }
}
