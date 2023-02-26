using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BookStore.Data.Test.Fixtures
{
    [CollectionDefinition(nameof(RepositoryCollection))]
    public class RepositoryCollection : ICollectionFixture<RepositoryFixture>
    {
    }
}
