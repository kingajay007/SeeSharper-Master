
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

    [ConnectionKey("Default"), DisplayName("Question"), InstanceName("Question"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class QuestionRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Query"), Size(255), NotNull, QuickSearch]
        public String Query
        {
            get { return Fields.Query[this]; }
            set { Fields.Query[this] = value; }
        }

        [DisplayName("Category"), NotNull, ForeignKey("[dbo].[Category]", "Id"), LeftJoin("jCategory"), TextualField("CategoryName")]
        public Int32? CategoryId
        {
            get { return Fields.CategoryId[this]; }
            set { Fields.CategoryId[this] = value; }
        }

        [DisplayName("Category Name"), Expression("jCategory.[Name]")]
        public String CategoryName
        {
            get { return Fields.CategoryName[this]; }
            set { Fields.CategoryName[this] = value; }
        }

        [DisplayName("Category Description"), Expression("jCategory.[Description]")]
        public String CategoryDescription
        {
            get { return Fields.CategoryDescription[this]; }
            set { Fields.CategoryDescription[this] = value; }
        }

        [DisplayName("Category Is Active"), Expression("jCategory.[IsActive]")]
        public Boolean? CategoryIsActive
        {
            get { return Fields.CategoryIsActive[this]; }
            set { Fields.CategoryIsActive[this] = value; }
        }

        [DisplayName("Category Short Name"), Expression("jCategory.[ShortName]")]
        public String CategoryShortName
        {
            get { return Fields.CategoryShortName[this]; }
            set { Fields.CategoryShortName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Query; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public QuestionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Query;
            public Int32Field CategoryId;

            public StringField CategoryName;
            public StringField CategoryDescription;
            public BooleanField CategoryIsActive;
            public StringField CategoryShortName;

            public RowFields()
                : base("[dbo].[Question]")
            {
                LocalTextPrefix = "ContentManagement.Question";
            }
        }
    }
}