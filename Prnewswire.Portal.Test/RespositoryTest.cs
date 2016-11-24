using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prnewswire.Portal.Core;
using Prnewswire.Portal.NHibernate;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Prnewswire.Portal.Core.Teacher;

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

            var respository = IocManager.Instance.Resolve<IRepository<Teacher>>();
            var t = respository.Get(1);            
        }
    }
}
