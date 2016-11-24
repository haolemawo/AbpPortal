using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prnewswire.Portal.NHibernate.DbMigrations.V20161124
{
    [Migration(2016112402)]
    public class _02_InsertData:AutoReversingMigration
    {
        public override void Up()
        {
            Insert.IntoTable("T_Teacher").Row(
               new
               {
                   Name = "Teacher Li"
               });

            Insert.IntoTable("T_Course").Row(
                new
                {
                    Name = "English",
                    Teacher_Id = 1
                });
        }
    }
}
