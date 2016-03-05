using FluentMigrator;

namespace SeeSharper.Migrations.DefaultDB
{
    [Migration(20160305063700)]
    public class DefaultDB_20160305_063700_CategoryEntityAdded : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Category")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Description").AsString().WithDefaultValue("")
                .WithColumn("IsActive").AsBoolean().WithDefaultValue(true);
        }
    }
}