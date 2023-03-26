using System;
using System.Collections.Generic;
using System.Text;
using Tienn.Abp.Localization;
using Volo.Abp.Application.Services;

namespace Tienn.Abp;

/* Inherit your application services from this class.
 */
public abstract class AbpAppService : ApplicationService
{
    protected AbpAppService()
    {
        LocalizationResource = typeof(AbpResource);
    }
}
