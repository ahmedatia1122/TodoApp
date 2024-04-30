using Volo.Abp.Modularity;

namespace TodoApplication;

[DependsOn(
    typeof(TodoApplicationApplicationModule),
    typeof(TodoApplicationDomainTestModule)
)]
public class TodoApplicationApplicationTestModule : AbpModule
{

}
