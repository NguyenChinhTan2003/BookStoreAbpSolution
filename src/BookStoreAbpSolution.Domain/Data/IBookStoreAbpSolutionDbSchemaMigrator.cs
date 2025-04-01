using System.Threading.Tasks;

namespace BookStoreAbpSolution.Data;

public interface IBookStoreAbpSolutionDbSchemaMigrator
{
    Task MigrateAsync();
}
