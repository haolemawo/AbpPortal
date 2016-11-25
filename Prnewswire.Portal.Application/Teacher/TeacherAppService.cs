using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prnewswire.Portal.Application.Teacher.Dtos;
using Prnewswire.Portal.Core;
using Abp.Domain.Repositories;
using Abp.Application.Services;
using AutoMapper;

namespace Prnewswire.Portal.Application.Teacher
{
    public class TeacherAppService : ApplicationService, ITeacherAppService
    {
        private readonly IRepository<Prnewswire.Portal.Core.Teacher.Teacher> _teacherRepository;

        public TeacherAppService(IRepository<Core.Teacher.Teacher> teacherRespository)
        {
            this._teacherRepository = teacherRespository;
        }

        public GetTeacherOutput GetTeacher(GetTeacherInput input)
        {
            var r = _teacherRepository.Get(input.Id);

            return new GetTeacherOutput
            {
                Teacher = Mapper.Map<TeacherDto>(r)
            };

        }
    }
}
