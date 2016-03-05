using FluentMigrator;

namespace SeeSharper.Migrations.DefaultDB
{
    [Migration(20160305074400)]
    public class DefaultDB_20160305_074400_QuestionEntityAdded : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Question")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Query").AsString().NotNullable()
                .WithColumn("CategoryId").AsInt32().NotNullable().ForeignKey("Category", "Id");

            Create.Table("Option")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Value").AsString().NotNullable()
                .WithColumn("IsCorrect").AsBoolean()
                .WithColumn("QuestionId").AsInt32().NotNullable().ForeignKey("Question", "Id");
                
        }
    }
}