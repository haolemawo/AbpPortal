using Abp.Dependency;
using AbpModuleDemoModule1;
using AbpModuleDemoModule2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpModuleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrapper = Abp.AbpBootstrapper.Create(typeof(AbpModuleDemoModule1.AbpModuleDemoModule1Module));
            bootstrapper.Initialize();
            var module2 = IocManager.Instance.Resolve<IModule2>();
            module2.doMethod2();

            Console.ReadLine();

        }
    }
}
