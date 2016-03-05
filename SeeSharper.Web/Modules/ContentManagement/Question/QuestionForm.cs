
namespace SeeSharper.ContentManagement.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ContentManagement.Question")]
    [BasedOnRow(typeof(Entities.QuestionRow))]
    public class QuestionForm
    {
        public String Query { get; set; }
        public Int32 CategoryId { get; set; }
    }
}