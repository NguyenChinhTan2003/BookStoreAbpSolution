using BookStoreAbpSolution.Samples;
using Xunit;

namespace BookStoreAbpSolution.EntityFrameworkCore.Domains;

[Collection(BookStoreAbpSolutionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreAbpSolutionEntityFrameworkCoreTestModule>
{

}
