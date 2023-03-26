using Volo.Abp.Modularity;

namespace Tienn.Abp;

[DependsOn(
    typeof(AbpApplicationModule),
    typeof(AbpDomainTestModule)
    )]
public class AbpApplicationTestModule : AbpModule
{

}
