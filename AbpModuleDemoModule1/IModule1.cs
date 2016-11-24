using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpModuleDemoModule1
{
    public interface IModule1: ITransientDependency
    {
        void doMethod();
    }
}
