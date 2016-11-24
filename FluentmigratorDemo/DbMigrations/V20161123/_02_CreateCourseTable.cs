using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentmigratorDemo.DbMigrations.V20161123
{
    [Profile("Development")]
    [Migration(2)]
    public class _02_CreateCourseTable : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("T_Course")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Name").AsString(255).NotNullable()
            .WithColumn("Teacher_Id").AsInt32().ForeignKey("T_teacher", "Id");
        }
        public override void Down()
        {
            Delete.Table("T_Course");
        }
    }
}
