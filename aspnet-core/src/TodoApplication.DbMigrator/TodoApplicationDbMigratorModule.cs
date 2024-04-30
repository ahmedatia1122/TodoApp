using TodoApplication.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TodoApplication.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TodoApplicationEntityFrameworkCoreModule),
    typeof(TodoApplicationApplicationContractsModule)
    )]
public class TodoApplicationDbMigratorModule : AbpModule
{
}
