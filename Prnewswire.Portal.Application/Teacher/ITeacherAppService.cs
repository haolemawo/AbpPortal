using Abp.Application.Services;
using Prnewswire.Portal.Application.Teacher.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prnewswire.Portal.Application.Teacher
{
    public interface ITeacherAppService:IApplicationService
    {
        GetTeacherOutput GetTeacher(GetTeacherInput input);
    }
}
