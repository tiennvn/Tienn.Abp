using Tienn.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Tienn.Abp;

[DependsOn(
    typeof(AbpEntityFrameworkCoreTestModule)
    )]
public class AbpDomainTestModule : AbpModule
{

}
