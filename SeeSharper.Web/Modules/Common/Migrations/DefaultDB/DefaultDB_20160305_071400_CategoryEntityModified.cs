using FluentMigrator;

namespace SeeSharper.Migrations.DefaultDB
{
    [Migration(20160305071400)]
    public class DefaultDB_20160305_071400_CategoryEntityModified : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Category")
                .AddColumn("ShortName").AsString(10).WithDefaultValue("SN");
                
        }
    }
}