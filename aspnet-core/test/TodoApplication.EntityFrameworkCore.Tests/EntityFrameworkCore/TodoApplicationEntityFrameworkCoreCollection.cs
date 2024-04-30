using Xunit;

namespace TodoApplication.EntityFrameworkCore;

[CollectionDefinition(TodoApplicationTestConsts.CollectionDefinitionName)]
public class TodoApplicationEntityFrameworkCoreCollection : ICollectionFixture<TodoApplicationEntityFrameworkCoreFixture>
{

}
