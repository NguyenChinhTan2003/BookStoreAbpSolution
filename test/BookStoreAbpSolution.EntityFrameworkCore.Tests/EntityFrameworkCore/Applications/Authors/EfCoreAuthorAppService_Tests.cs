using BookStoreAbpSolution;
using BookStoreAbpSolution.Authors;
using BookStoreAbpSolution.EntityFrameworkCore;
using Xunit;

namespace Acme.BookStore.EntityFrameworkCore.Applications.Authors;

[Collection(BookStoreAbpSolutionTestConsts.CollectionDefinitionName)]
public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<BookStoreAbpSolutionEntityFrameworkCoreTestModule>
{

}
