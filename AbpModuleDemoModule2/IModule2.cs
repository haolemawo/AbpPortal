using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpModuleDemoModule2
{
    public interface IModule2:Abp.Dependency.ITransientDependency
    {
        void doMethod2();
    }
}
