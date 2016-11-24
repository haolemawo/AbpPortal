using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentmigratorTest.DbMigrations.V20161123
{
    [Profile("Development")]
    public class _04_InsertCourseSeed : FluentMigrator.Migration
    {
        public override void Up()
        {
            Insert.IntoTable("T_Course").Row(
                new
                {
                    Id = 1,
                    Name = "English",
                    Teacher_Id = 1
                });
        }
        public override void Down()
        {

        }
    }
}
