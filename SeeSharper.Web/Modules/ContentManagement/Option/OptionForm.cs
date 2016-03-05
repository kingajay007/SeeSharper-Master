
namespace SeeSharper.ContentManagement.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ContentManagement.Option")]
    [BasedOnRow(typeof(Entities.OptionRow))]
    public class OptionForm
    {
        public String Value { get; set; }
        public Boolean IsCorrect { get; set; }
        public Int32 QuestionId { get; set; }
    }
}