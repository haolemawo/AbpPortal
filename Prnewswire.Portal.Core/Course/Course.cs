using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prnewswire.Portal.Core.Course
{
    public class Course:Entity
    {
        public virtual string Name { get; set; }

        public virtual Teacher.Teacher Teacher { get; set; }
    }
}
