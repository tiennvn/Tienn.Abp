using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Tienn.Abp;

[Dependency(ReplaceServices = true)]
public class AbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Abp";
}
