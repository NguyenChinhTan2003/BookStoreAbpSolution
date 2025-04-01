using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStoreAbpSolution.Data;
using Volo.Abp.DependencyInjection;

namespace BookStoreAbpSolution.EntityFrameworkCore;

public class EntityFrameworkCoreBookStoreAbpSolutionDbSchemaMigrator
    : IBookStoreAbpSolutionDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookStoreAbpSolutionDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BookStoreAbpSolutionDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookStoreAbpSolutionDbContext>()
            .Database
            .MigrateAsync();
    }
}
