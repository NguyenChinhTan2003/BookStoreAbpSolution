using Volo.Abp.Modularity;

namespace BookStoreAbpSolution;

/* Inherit from this class for your domain layer tests. */
public abstract class BookStoreAbpSolutionDomainTestBase<TStartupModule> : BookStoreAbpSolutionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
