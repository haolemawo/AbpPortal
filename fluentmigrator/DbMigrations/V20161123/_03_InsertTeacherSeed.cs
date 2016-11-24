using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluentmigratorTest.DbMigrations.V20161123
{
    [Profile("Development")]
    public class _03_InsertTeacherSeed:FluentMigrator.Migration
    {
        public override void Up()
        {
            Insert.IntoTable("T_Teacher").Row(
                new {
                    Id = 1,
                    Name = "Teacher Li"
                });
        }
        public override void Down()
        {
            
        }
    }
}
