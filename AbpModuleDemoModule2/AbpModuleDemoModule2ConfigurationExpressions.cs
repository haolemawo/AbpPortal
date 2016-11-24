using Abp.Configuration.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpModuleDemoModule2
{
    public static class AbpModuleDemoModule2ConfigurationExpressions
    {
        public static AbpModuleDemoModule2Config AbpModuleDemoModule2(this IModuleConfigurations moduleConfigurations)
        {
            return moduleConfigurations.AbpConfiguration.Get<AbpModuleDemoModule2Config>();
        }
    }
}
