using Abp.Modules;
using Prnewswire.Portal.Core;
using Prnewswire.Portal.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp.Configuration.Startup;
using Abp.AutoMapper;

namespace Prnewswire.Portal.Application
{
    [DependsOn(typeof(AbpPortalCoreModule),typeof(AbpAutoMapperModule),typeof(AbpPortalRespositoryModule))]
    public class AbpPortalApplicationModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                DtoMappings.Map(mapper);
            });
        }
    }
}
