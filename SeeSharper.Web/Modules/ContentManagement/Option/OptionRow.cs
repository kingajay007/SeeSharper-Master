
namespace SeeSharper.ContentManagement.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Option"), InstanceName("Option"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class OptionRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Value"), Size(255), NotNull, QuickSearch]
        public String Value
        {
            get { return Fields.Value[this]; }
            set { Fields.Value[this] = value; }
        }

        [DisplayName("Is Correct"), NotNull]
        public Boolean? IsCorrect
        {
            get { return Fields.IsCorrect[this]; }
            set { Fields.IsCorrect[this] = value; }
        }

        [DisplayName("Question"), NotNull, ForeignKey("[dbo].[Question]", "Id"), LeftJoin("jQuestion"), TextualField("QuestionQuery")]
        public Int32? QuestionId
        {
            get { return Fields.QuestionId[this]; }
            set { Fields.QuestionId[this] = value; }
        }

        [DisplayName("Question Query"), Expression("jQuestion.[Query]")]
        public String QuestionQuery
        {
            get { return Fields.QuestionQuery[this]; }
            set { Fields.QuestionQuery[this] = value; }
        }

        [DisplayName("Question Category Id"), Expression("jQuestion.[CategoryId]")]
        public Int32? QuestionCategoryId
        {
            get { return Fields.QuestionCategoryId[this]; }
            set { Fields.QuestionCategoryId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OptionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Value;
            public BooleanField IsCorrect;
            public Int32Field QuestionId;

            public StringField QuestionQuery;
            public Int32Field QuestionCategoryId;

            public RowFields()
                : base("[dbo].[Option]")
            {
                LocalTextPrefix = "ContentManagement.Option";
            }
        }
    }
}