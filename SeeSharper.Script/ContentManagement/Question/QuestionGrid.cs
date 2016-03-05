
namespace SeeSharper.ContentManagement
{
    using jQueryApi;
    using Serenity;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    [ColumnsKey("ContentManagement.Question"), IdProperty(QuestionRow.IdProperty), NameProperty(QuestionRow.NameProperty)]
    [DialogType(typeof(QuestionDialog)), LocalTextPrefix(QuestionRow.LocalTextPrefix), Service(QuestionService.BaseUrl)]
    public class QuestionGrid : EntityGrid<QuestionRow>
    {
        public QuestionGrid(jQueryObject container)
            : base(container)
        {
        }
    }
}