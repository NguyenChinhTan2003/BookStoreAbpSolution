using BookStoreAbpSolution.Books;
using Xunit;

namespace BookStoreAbpSolution.EntityFrameworkCore.Applications.Books;

[Collection(BookStoreAbpSolutionTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BookStoreAbpSolutionEntityFrameworkCoreTestModule>
{

}