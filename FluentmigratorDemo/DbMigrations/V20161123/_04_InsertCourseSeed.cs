using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentmigratorDemo.DbMigrations.V20161123
{
    [Profile("Development")]
    [Migration(5)]
    public class _04_InsertCourseSeed : FluentMigrator.Migration
    {
        public override void Up()
        {
            Insert.IntoTable("T_Course").Row(
                new
                {                   
                    Name = "English",
                    Teacher_Id = 1
                });
        }
        public override void Down()
        {

        }
    }
}
