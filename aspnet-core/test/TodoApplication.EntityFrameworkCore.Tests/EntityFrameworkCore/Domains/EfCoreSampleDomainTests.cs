using TodoApplication.Samples;
using Xunit;

namespace TodoApplication.EntityFrameworkCore.Domains;

[Collection(TodoApplicationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TodoApplicationEntityFrameworkCoreTestModule>
{

}
