using AbpModuleDemoModule1;
using AbpModuleDemoModule2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpModuleDemoModule1
{
    public class Module1 : IModule1
    {
        public void doMethod()
        {
            Console.WriteLine("doMethod in Module1");
        }        
    }
}
