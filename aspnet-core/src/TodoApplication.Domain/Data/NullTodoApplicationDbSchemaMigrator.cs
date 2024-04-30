using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TodoApplication.Data;

/* This is used if database provider does't define
 * ITodoApplicationDbSchemaMigrator implementation.
 */
public class NullTodoApplicationDbSchemaMigrator : ITodoApplicationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
