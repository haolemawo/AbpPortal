using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prnewswire.Portal.Core;
using Prnewswire.Portal.NHibernate;
using Abp.Dependency;

namespace Prnewswire.Portal.Test
{
    [TestClass]
    public class RespositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var b = Abp.AbpBootstrapper.Create(typeof(AbpPortalRespositoryModule));
            b.Initialize();

            var respository = IocManager.Instance.Resolve<AbpPortalRespositoryModule>();
            respository.PreInitialize();
        }
    }
}
