using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BookStoreAbpSolution.Data;

/* This is used if database provider does't define
 * IBookStoreAbpSolutionDbSchemaMigrator implementation.
 */
public class NullBookStoreAbpSolutionDbSchemaMigrator : IBookStoreAbpSolutionDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
