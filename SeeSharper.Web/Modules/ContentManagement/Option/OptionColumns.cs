
namespace SeeSharper.ContentManagement.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("ContentManagement.Option")]
    [BasedOnRow(typeof(Entities.OptionRow))]
    public class OptionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Value { get; set; }
        public Boolean IsCorrect { get; set; }
        public Int32 QuestionId { get; set; }
    }
}