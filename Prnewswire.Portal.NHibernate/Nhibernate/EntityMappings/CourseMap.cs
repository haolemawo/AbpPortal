using Abp.NHibernate.EntityMappings;
using Prnewswire.Portal.Core.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prnewswire.Portal.NHibernate.Nhibernate.EntityMappings
{
    public class CourseMap : EntityMap<Course>
    {
        public CourseMap() : base("T_Course")
        {
            Map(x => x.Name);
            HasOne(x => x.Teacher)
                .Cascade.None();
        }

    }
}
