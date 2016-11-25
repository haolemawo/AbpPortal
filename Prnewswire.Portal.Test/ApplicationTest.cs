using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prnewswire.Portal.Application;
using Abp.Dependency;
using Prnewswire.Portal.Core.Teacher;
using Prnewswire.Portal.Application.Teacher;

namespace Prnewswire.Portal.Test
{
    [TestClass]
    public class ApplicationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var b = Abp.AbpBootstrapper.Create(typeof(AbpPortalApplicationModule));
            b.Initialize();

            var appService = IocManager.Instance.Resolve<Prnewswire.Portal.Application.Teacher.ITeacherAppService>();
            var teacher = appService.GetTeacher(new Application.Teacher.Dtos.GetTeacherInput {
                Id = 1
            });
        }
    }
}
