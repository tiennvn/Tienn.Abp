using System.Threading.Tasks;

namespace Tienn.Abp.Data;

public interface IAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
