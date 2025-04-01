using Volo.Abp.Modularity;

namespace BookStoreAbpSolution;

[DependsOn(
    typeof(BookStoreAbpSolutionDomainModule),
    typeof(BookStoreAbpSolutionTestBaseModule)
)]
public class BookStoreAbpSolutionDomainTestModule : AbpModule
{

}
