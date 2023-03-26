using Tienn.Abp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Tienn.Abp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpEntityFrameworkCoreModule),
    typeof(AbpApplicationContractsModule)
    )]
public class AbpDbMigratorModule : AbpModule
{

}
