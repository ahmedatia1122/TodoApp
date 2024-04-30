using TodoApplication.Samples;
using Xunit;

namespace TodoApplication.EntityFrameworkCore.Applications;

[Collection(TodoApplicationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TodoApplicationEntityFrameworkCoreTestModule>
{

}
