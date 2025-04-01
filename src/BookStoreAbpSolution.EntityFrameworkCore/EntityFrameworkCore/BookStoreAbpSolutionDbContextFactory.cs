using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BookStoreAbpSolution.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BookStoreAbpSolutionDbContextFactory : IDesignTimeDbContextFactory<BookStoreAbpSolutionDbContext>
{
    public BookStoreAbpSolutionDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        BookStoreAbpSolutionEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<BookStoreAbpSolutionDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new BookStoreAbpSolutionDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BookStoreAbpSolution.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
