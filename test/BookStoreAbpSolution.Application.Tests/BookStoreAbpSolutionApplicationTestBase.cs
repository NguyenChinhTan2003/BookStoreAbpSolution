using Volo.Abp.Modularity;

namespace BookStoreAbpSolution;

public abstract class BookStoreAbpSolutionApplicationTestBase<TStartupModule> : BookStoreAbpSolutionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
