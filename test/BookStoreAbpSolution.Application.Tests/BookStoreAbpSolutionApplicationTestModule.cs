using Volo.Abp.Modularity;

namespace BookStoreAbpSolution;

[DependsOn(
    typeof(BookStoreAbpSolutionApplicationModule),
    typeof(BookStoreAbpSolutionDomainTestModule)
)]
public class BookStoreAbpSolutionApplicationTestModule : AbpModule
{

}
