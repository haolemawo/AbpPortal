using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prnewswire.Portal.Core.Teacher
{    
    public class Teacher : Entity
    {
        public virtual string Name { get; set; }

        public virtual IList<Course.Course> Courses { get; set; }
    }
}
