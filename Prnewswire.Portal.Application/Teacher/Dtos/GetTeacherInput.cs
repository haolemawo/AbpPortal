using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prnewswire.Portal.Application.Teacher.Dtos
{
    public class GetTeacherInput
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("[GetTeacherInput > Id = {0}, Name = {1}]", Id, Name);
        }
    }
}
