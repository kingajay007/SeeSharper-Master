
namespace SeeSharper.ContentManagement.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("ContentManagement.Question")]
    [BasedOnRow(typeof(Entities.QuestionRow))]
    public class QuestionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Query { get; set; }
        public Int32 CategoryId { get; set; }
    }
}