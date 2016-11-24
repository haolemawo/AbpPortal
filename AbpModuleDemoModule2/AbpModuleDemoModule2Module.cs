using Abp.Dependency;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbpModuleDemoModule2
{
    public class AbpModuleDemoModule2Module:AbpModule
    {        
        public override void PreInitialize()
        {
            IocManager.Register<AbpModuleDemoModule2Config>();
        }

        public override void Initialize()
        {
            var parameter = Configuration.Modules.AbpModuleDemoModule2().Parameter;

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());            
        }
    }
}
