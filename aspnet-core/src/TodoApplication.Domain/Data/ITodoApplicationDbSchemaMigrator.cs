using System.Threading.Tasks;

namespace TodoApplication.Data;

public interface ITodoApplicationDbSchemaMigrator
{
    Task MigrateAsync();
}
