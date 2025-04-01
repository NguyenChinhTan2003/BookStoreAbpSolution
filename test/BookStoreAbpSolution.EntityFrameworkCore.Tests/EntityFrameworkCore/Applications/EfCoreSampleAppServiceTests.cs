using BookStoreAbpSolution.Samples;
using Xunit;

namespace BookStoreAbpSolution.EntityFrameworkCore.Applications;

[Collection(BookStoreAbpSolutionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStoreAbpSolutionEntityFrameworkCoreTestModule>
{

}
