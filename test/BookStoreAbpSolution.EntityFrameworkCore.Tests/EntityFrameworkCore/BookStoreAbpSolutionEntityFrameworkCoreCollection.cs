﻿using Xunit;

namespace BookStoreAbpSolution.EntityFrameworkCore;

[CollectionDefinition(BookStoreAbpSolutionTestConsts.CollectionDefinitionName)]
public class BookStoreAbpSolutionEntityFrameworkCoreCollection : ICollectionFixture<BookStoreAbpSolutionEntityFrameworkCoreFixture>
{

}
