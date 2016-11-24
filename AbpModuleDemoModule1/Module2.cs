using AbpModuleDemoModule2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpModuleDemoModule1
{
    public class Module2 : IModule2
    {
        public AbpModuleDemoModule2Config Config { get; set; }

        public void doMethod2()
        {
            Console.WriteLine("doMethod in Module2");
            Console.WriteLine("Config : "+ Config.Parameter);
        }
    }
}
