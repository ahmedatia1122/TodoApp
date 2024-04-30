using Volo.Abp.Modularity;

namespace TodoApplication;

/* Inherit from this class for your domain layer tests. */
public abstract class TodoApplicationDomainTestBase<TStartupModule> : TodoApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
