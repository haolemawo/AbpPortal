using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prnewswire.Portal.Application.Teacher.Dtos
{
    public class TeacherDto:EntityDto
    {
        public string Name;

        public override string ToString()
        {
            return string.Format(
               "[Teacher Id={0}, Name={1}]",
               Id,
               Name);
        }
    }
}
