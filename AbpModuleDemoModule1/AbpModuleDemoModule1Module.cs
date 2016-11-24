using Abp.Dependency;
using Abp.Modules;
using AbpModuleDemoModule2;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbpModuleDemoModule1
{
    [DependsOn(typeof(AbpModuleDemoModule2Module))]
    public class AbpModuleDemoModule1Module:AbpModule
    {        
        public override void PreInitialize()
        {
            Configuration.Modules.AbpModuleDemoModule2().Parameter = "from module1";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());            
        }
    }
}
