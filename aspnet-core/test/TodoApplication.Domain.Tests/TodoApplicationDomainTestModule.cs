using Volo.Abp.Modularity;

namespace TodoApplication;

[DependsOn(
    typeof(TodoApplicationDomainModule),
    typeof(TodoApplicationTestBaseModule)
)]
public class TodoApplicationDomainTestModule : AbpModule
{

}
