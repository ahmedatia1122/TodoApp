using Volo.Abp.Modularity;

namespace TodoApplication;

public abstract class TodoApplicationApplicationTestBase<TStartupModule> : TodoApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
