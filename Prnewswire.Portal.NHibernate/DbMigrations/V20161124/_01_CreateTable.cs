using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prnewswire.Portal.NHibernate.DbMigrations.V20161124
{
    [Migration(2016112401)]
    public class _01_CreateTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("T_Teacher")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Name").AsString(255).NotNullable();
            Create.Table("T_Course")
               .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
               .WithColumn("Name").AsString(255).NotNullable()
               .WithColumn("Teacher_Id").AsInt32().ForeignKey("T_teacher", "Id");
        }
    }
}
