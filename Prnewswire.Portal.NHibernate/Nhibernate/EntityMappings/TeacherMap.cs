using Abp.NHibernate.EntityMappings;
using Prnewswire.Portal.Core.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prnewswire.Portal.NHibernate.Nhibernate.EntityMappings
{
    public class TeacherMap:EntityMap<Teacher>
    {
        public TeacherMap():base("T_Teacher")
        {
            Map(x => x.Name);
            HasMany(x => x.Courses)
                .Cascade.All()
                .Table("T_Course")
                .KeyColumn("Teacher_Id");
        }
    }
}
