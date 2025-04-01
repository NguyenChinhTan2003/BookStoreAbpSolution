using BookStoreAbpSolution.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BookStoreAbpSolution.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStoreAbpSolutionEntityFrameworkCoreModule),
    typeof(BookStoreAbpSolutionApplicationContractsModule)
)]
public class BookStoreAbpSolutionDbMigratorModule : AbpModule
{
}
